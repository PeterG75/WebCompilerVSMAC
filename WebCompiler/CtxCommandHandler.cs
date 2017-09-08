using System;
using MonoDevelop.Components.Commands;
using MonoDevelop.Ide;
using MonoDevelop.Ide.Gui.Components;

namespace WebCompiler
{
	// http://www.monodevelop.com/developers/articles/extending-the-project-pad/
	public enum CtxCommands
	{
		COMPILE	
	}

	class Builder : NodeBuilderExtension
	{
		public override Type CommandHandlerType
		{
			get
			{
				return typeof(CtxCommandHandler);
			}
		}
		public override bool CanBuildNode(Type dataType)
		{
			return true;
		}
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