using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppDependencyInyection.UI.Helpers
{
    public static class VistasHelper
    {
        public delegate void ViewChange(int width, int height);

        public static event ViewChange? LoadNewSize;

        public static void ChangeViewSize(int width, int height)
        {
            LoadNewSize?.Invoke(width, height);

        }



    }
}
