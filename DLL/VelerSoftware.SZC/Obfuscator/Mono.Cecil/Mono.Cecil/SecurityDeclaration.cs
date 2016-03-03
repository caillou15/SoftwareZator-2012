// *****************************************************************************
// 
//  � Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************


using System;

using Mono.Collections.Generic;

namespace Mono.Cecil {

	public enum SecurityAction : ushort {
		Request = 1,
		Demand = 2,
		Assert = 3,
		Deny = 4,
		PermitOnly = 5,
		LinkDemand = 6,
		InheritDemand = 7,
		RequestMinimum = 8,
		RequestOptional = 9,
		RequestRefuse = 10,
		PreJitGrant = 11,
		PreJitDeny = 12,
		NonCasDemand = 13,
		NonCasLinkDemand = 14,
		NonCasInheritance = 15
	}

	public interface ISecurityDeclarationProvider : IMetadataTokenProvider {

		bool HasSecurityDeclarations { get; }
		Collection<SecurityDeclaration> SecurityDeclarations { get; }
	}

	public sealed class SecurityAttribute : ICustomAttribute {

		TypeReference attribute_type;

		internal Collection<CustomAttributeNamedArgument> fields;
		internal Collection<CustomAttributeNamedArgument> properties;

		public TypeReference AttributeType {
			get { return attribute_type; }
			set { attribute_type = value; }
		}

		public bool HasFields {
			get { return !fields.IsNullOrEmpty (); }
		}

		public Collection<CustomAttributeNamedArgument> Fields {
			get { return fields ?? (fields = new Collection<CustomAttributeNamedArgument> ()); }
		}

		public bool HasProperties {
			get { return !properties.IsNullOrEmpty (); }
		}

		public Collection<CustomAttributeNamedArgument> Properties {
			get { return properties ?? (properties = new Collection<CustomAttributeNamedArgument> ()); }
		}

		public SecurityAttribute (TypeReference attributeType)
		{
			this.attribute_type = attributeType;
		}
	}

	public sealed class SecurityDeclaration {

		readonly internal uint signature;
		readonly ModuleDefinition module;

		internal bool resolved;
		SecurityAction action;
		internal Collection<SecurityAttribute> security_attributes;

		public SecurityAction Action {
			get { return action; }
			set { action = value; }
		}

		public bool HasSecurityAttributes {
			get {
				Resolve ();

				return !security_attributes.IsNullOrEmpty ();
			}
		}

		public Collection<SecurityAttribute> SecurityAttributes {
			get {
				Resolve ();

				return security_attributes ?? (security_attributes = new Collection<SecurityAttribute> ());
			}
		}

		internal bool HasImage {
			get { return module != null && module.HasImage; }
		}

		internal SecurityDeclaration (SecurityAction action, uint signature, ModuleDefinition module)
		{
			this.action = action;
			this.signature = signature;
			this.module = module;
		}

		public SecurityDeclaration (SecurityAction action)
		{
			this.action = action;
			this.resolved = true;
		}

		public byte [] GetBlob ()
		{
			if (!HasImage || signature == 0)
				throw new NotSupportedException ();

			return module.Read (this, (declaration, reader) => reader.ReadSecurityDeclarationBlob (declaration.signature));
		}

		void Resolve ()
		{
			if (resolved || !HasImage)
				return;

			module.Read (this, (declaration, reader) => {
				reader.ReadSecurityDeclarationSignature (declaration);
				return this;
			});

			resolved = true;
		}
	}

	static partial class Mixin {

		public static bool GetHasSecurityDeclarations (
			this ISecurityDeclarationProvider self,
			ModuleDefinition module)
		{
			return module.HasImage ()
				? module.Read (self, (provider, reader) => reader.HasSecurityDeclarations (provider))
				: false;
		}

		public static Collection<SecurityDeclaration> GetSecurityDeclarations (
			this ISecurityDeclarationProvider self,
			ModuleDefinition module)
		{
			return module.HasImage ()
				? module.Read (self, (provider, reader) => reader.ReadSecurityDeclarations (provider))
				: new Collection<SecurityDeclaration> ();
		}
	}
}
