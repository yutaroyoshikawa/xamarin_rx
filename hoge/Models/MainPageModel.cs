using Prism.Mvvm;
using hoge.Services;
using System.Threading.Tasks;

namespace hoge.Models
{
    public class MainPageModel : BindableBase
    {
        private ApiGetService ApiGetService = new ApiGetService();

        public MainPageModel()
        {
            this.count = 0;
        }

        private int count;
        // TODO: 型定義がAPIの返り値の形になるように修正する。
        private int probrems;
        private bool loading;

        public int Count
        {
            get { return count; }
            set { SetProperty(ref this.count, value); }
        }

        public int Probrems
        {
            get { return probrems; }
            set { SetProperty(ref probrems, value); }
        }

        public bool Loading
        {
            get { return loading; }
            set { SetProperty(ref loading, value); }
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

        public async Task GetProbrems()
        {
            Loading = true;
            var probrems = await this.ApiGetService.ProblemAll();
            Probrems = probrems;
            Loading = false;
        }
    }
}
