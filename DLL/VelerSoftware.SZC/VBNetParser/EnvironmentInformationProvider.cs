﻿// *****************************************************************************
// 
//  © Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************




using System;

namespace VelerSoftware.SZC.VBNetParser
{
	public interface IEnvironmentInformationProvider
	{
		bool HasField(string reflectionTypeName, int typeParameterCount, string fieldName);
	}
	
	sealed class DummyEnvironmentInformationProvider : IEnvironmentInformationProvider
	{
		internal static readonly IEnvironmentInformationProvider Instance = new DummyEnvironmentInformationProvider();
		
		public bool HasField(string reflectionTypeName, int typeParameterCount, string fieldName)
		{
			return false;
		}
	}
}
