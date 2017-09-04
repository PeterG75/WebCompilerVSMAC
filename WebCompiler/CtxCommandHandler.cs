using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui.Components;

namespace WebCompiler
{
	public enum CtxCommands
	{
		COMPILE	
	}

	public class CtxCommandHandler : NodeCommandHandler
	{
		[CommandHandler(CtxCommands.COMPILE)]
		protected void OnShowProperties ()
		{
			MessageService.ShowMessage("hello");
		}

		public override void ActivateItem()
		{
			base.ActivateItem();
		}
	}
}