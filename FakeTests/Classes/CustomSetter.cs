﻿namespace FakeTests.Classes
{
    internal class CustomSetter
    {
        private string private_custom_setter;
        public string custom_setter
        {
            get
            {
                return private_custom_setter;
            }

            set
            {
                private_custom_setter = value == "Test" ? value : string.Empty;
            }
        }
    }
}
