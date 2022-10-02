using System;

namespace MyLibrary
{
    public class MyClass
    {
        private String _myProperty;
        public String MyProperty { get {return _myProperty;} }

        public MyClass(String _myProperty)
        {
            this._myProperty = _myProperty;
        }
    }
}