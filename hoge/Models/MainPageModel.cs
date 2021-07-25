using Prism.Mvvm;
using System.Threading.Tasks;

namespace hoge.Models
{
    public class MainPageModel : BindableBase
    {
        public MainPageModel()
        {
            this.count = 0;
        }

        private int count;

        public int Count
        {
            get { return count; }
            set { SetProperty(ref this.count, value); }
        }

        public void Increment()
        {
            Count++;
        }

        public async Task AsyncIncrement()
        {
            await Task.Delay(3000);
            Count++;
        }
    }
}
