using System.ComponentModel;
using System.Runtime.CompilerServices;
using TipCalculator.Models;
using Xamarin.Forms;

namespace TipCalculator.ViewModels
{
    public class MainPageViewModel
    {
        public Command DoOperations { get; set; }

        public TipModel TipModel { get; set; }

        public MainPageViewModel()
        {
            DoOperations = new Command(OnDoOperations);

            TipModel = new TipModel()
            {
                Total = 100,
                Tip = 5,
                PeopleCount = 2
            };
        }
        
        protected void OnDoOperations()
        {
            TipModel.TotalTip = (TipModel.Total * TipModel.Tip) / 100;
            TipModel.TotalWithTip = TipModel.Total + TipModel.TotalTip;
            TipModel.TipPerPerson = TipModel.TotalTip / TipModel.PeopleCount;
            TipModel.TotalPerPerson = TipModel.TotalWithTip / TipModel.PeopleCount;
        }
    }
}
