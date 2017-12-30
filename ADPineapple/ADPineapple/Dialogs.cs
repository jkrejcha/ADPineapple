using ADPineapple.Properties;
using System;
using TaskDialogInterop;

namespace ADPineapple
{
	public static class Dialogs
	{
		public static TaskDialogResult ShowDialog(DialogType Type)
		{
			switch (Type)
			{
				case DialogType.DeleteUserWarning:
					return ShowWarningConfirmation(Resources.ConfDeleteUserMainInstruction,
												   Resources.ConfDeleteUserText,
												   Resources.ConfDeleteCaption);
				case DialogType.Unknown:
				default:
					ShowSimpleBox(Resources.ErrBadErrorMsgMainInstruction, Resources.ErrBadErrorMsgText,
								  Resources.ErrBadErrorMsgCaption, VistaTaskDialogIcon.Error);
					return TaskDialogResult.Empty;
			}
		}

		private static TaskDialogResult ShowConnectionDialog(String mainInstruction, String text, String caption)
		{
			TaskDialogOptions options = new TaskDialogOptions()
			{
				MainInstruction = mainInstruction,
				Content = text,
				Title = caption,
				ShowMarqueeProgressBar = true,
				CustomButtons = new string[] { "&Cancel" },
				AllowDialogCancellation = true,
			};
			throw new NotImplementedException();
		}

		private static TaskDialogResult ShowWarningConfirmation(String mainInstruction, String text, String caption)
		{
			TaskDialogOptions options = new TaskDialogOptions()
			{
				MainIcon = VistaTaskDialogIcon.Warning,
				MainInstruction = mainInstruction,
				Content = text,
				Title = caption
			};
			return TaskDialog.Show(options);
		}

		private static void ShowSimpleBox(String mainInstruction, String text, String caption, VistaTaskDialogIcon icon)
		{
			TaskDialogOptions options = new TaskDialogOptions()
			{
				MainIcon = icon,
				MainInstruction = mainInstruction,
				Content = text,
				Title = caption
			};
			TaskDialog.Show(options);
		}
	}

	public enum DialogType
	{
		Unknown = 0,
		DeleteUserWarning = 1,
	}
}
