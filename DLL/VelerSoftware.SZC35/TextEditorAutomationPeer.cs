// *****************************************************************************
// 
//  � Veler Software 2012. All rights reserved.
//  The current code and the associated software are the proprietary 
//  information of Etienne Baudoux from Veler Software and are
//  supplied subject to licence terms.
// 
//  www.velersoftware.com
// *****************************************************************************

// <file>
//     <copyright see="prj:///doc/copyright.txt"/>
//     <license see="prj:///doc/license.txt"/>
//     <author name="Daniel Grunwald"/>
//     <version>$Revision: 4910 $</version>
// </file>

using System;
using System.Diagnostics;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;

using VelerSoftware.SZC35.Utils;

namespace VelerSoftware.SZC35
{
	/// <summary>
	/// Exposes <see cref="TextEditor"/> to automation.
	/// </summary>
	public class TextEditorAutomationPeer : FrameworkElementAutomationPeer, IValueProvider
	{
		/// <summary>
		/// Creates a new TextEditorAutomationPeer instance.
		/// </summary>
		public TextEditorAutomationPeer(TextEditor owner) : base(owner)
		{
			Debug.WriteLine("TextEditorAutomationPeer was created");
		}
		
		private TextEditor TextEditor {
			get { return (TextEditor)base.Owner; }
		}
		
		void IValueProvider.SetValue(string value)
		{
			this.TextEditor.Text = value;
		}
		
		string IValueProvider.Value {
			get { return this.TextEditor.Text; }
		}
		
		bool IValueProvider.IsReadOnly {
			get { return this.TextEditor.IsReadOnly; }
		}
		
		/// <inheritdoc/>
		public override object GetPattern(PatternInterface patternInterface)
		{
			if (patternInterface == PatternInterface.Value)
				return this;
			
			if (patternInterface == PatternInterface.Scroll) {
				ScrollViewer scrollViewer = this.TextEditor.ScrollViewer;
				if (scrollViewer != null)
					return UIElementAutomationPeer.CreatePeerForElement(scrollViewer);
			}
			
			return base.GetPattern(patternInterface);
		}
		
		internal void RaiseIsReadOnlyChanged(bool oldValue, bool newValue)
		{
			RaisePropertyChangedEvent(ValuePatternIdentifiers.IsReadOnlyProperty, Boxes.Box(oldValue), Boxes.Box(newValue));
		}
	}
}
