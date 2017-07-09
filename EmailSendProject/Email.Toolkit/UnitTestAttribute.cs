using System;
namespace Email.Toolkit
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method,AllowMultiple = true,Inherited = true)]
    public class UnitTestAttribute:Attribute
    {
       

        public UnitTestAttribute(bool isDebug){
            this._isDebug = isDebug;
        }

		public UnitTestAttribute(string className, double version)
		{
			this._className = className;
			this._version = version;
		}

        public UnitTestAttribute(string className, double version,bool isDebug){
            this._className = className;
            this._version = version;
            this._isDebug = isDebug;
        }

        private string _className=string.Empty;
        private double _version = 1.0;

        private bool _isDebug;
        /// <summary>
        /// Gets the name of the class.
        /// </summary>
        /// <returns>The class name.</returns>
        public string GetClassName()
        {
            return this._className;
        }
        /// <summary>
        /// Gets the version.
        /// </summary>
        /// <returns>The version.</returns>
        public double GetVersion(){
            return this._version;
        }

    }
}
