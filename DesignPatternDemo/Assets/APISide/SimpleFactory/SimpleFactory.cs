///---------------------------------
/// SimpleObjectB
///---------------------------------

namespace Pattern.SimpleFactory
{
    public static class SimpleFactory
    {
        public static ISimpleObject Make(SimpleMenu objInMenu = SimpleMenu.NONE)
        {
            switch (objInMenu)
            {
                case SimpleMenu.COFFEE:
                    return new SimpleObjectB();
                case SimpleMenu.BLACKTEA:
                    return new SimpleObjectA();
                case SimpleMenu.NONE:
                default:
                    return default;
            }
        }
    }
}
