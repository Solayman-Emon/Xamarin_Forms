using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Embedded_Images
{
    [ContentProperty (nameof(Source)) ]
    class  ImageResourceEntension : IMarkupExtension
    {
        public string Source { get; set; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
           if(Source == null)
            {
                return null;
            }

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourceEntension).GetTypeInfo().Assembly);

            return imageSource;
        }
    }
}
