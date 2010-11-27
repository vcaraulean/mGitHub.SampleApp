using Caliburn.Micro;

namespace mGitHub.SampleApp.ViewModels
{
	[SurviveTombstone]
	public class PivotViewModel : Conductor<IScreen>.Collection.OneActive
	{
		readonly PivotFix<IScreen> pivotFix;

		public PivotViewModel()
		{
			pivotFix = new PivotFix<IScreen>(this);
		}

		protected override void OnViewLoaded(object view)
		{
			pivotFix.OnViewLoaded(view, base.OnViewLoaded);
		}

		protected override void ChangeActiveItem(IScreen newItem, bool closePrevious)
		{
			pivotFix.ChangeActiveItem(newItem, closePrevious, base.ChangeActiveItem);
		}
	}
}