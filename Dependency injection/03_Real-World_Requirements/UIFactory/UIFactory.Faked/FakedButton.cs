using UIFactory.Core;
using UIFactory.Faked.Properties;

namespace UIFactory.Faked
{
   public sealed class FakedButton : ButtonBase
   {
      public FakedButton()
      {
         BackgroundImage = Resources.button;
         Size = BackgroundImage.Size;
      }
   }
}