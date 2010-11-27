using System.Windows.Controls.Primitives;
using mGitHub.SampleApp.Views.ProgressBar;

namespace mGitHub.SampleApp.Services
{
	public interface IProgressService
	{
		void Show();
		void Hide();
	}

	public class ProgressService : IProgressService
	{
		private readonly Popup Popup;

		public ProgressService()
		{
			Popup = new Popup
			{
				VerticalOffset = 180, 
				Child = new ProgressView()
			};
		}

		public void Show()
		{
			Popup.IsOpen = true;
		}

		public void Hide()
		{
			Popup.IsOpen = false;
		}
	}
}
