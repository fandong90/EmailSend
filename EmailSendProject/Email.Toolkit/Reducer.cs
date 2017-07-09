using System;
namespace Email.Toolkit
{
    public abstract class Reducer
    {

        /// <summary>
        /// Step this instance.
        /// </summary>
        public virtual void Step(){
            
        }

        /// <summary>
        /// Reduce the specified context.
        /// </summary>
        /// <returns>The reduce.</returns>
        /// <param name="context">Context.</param>
        public virtual void Reduce(Context context){
            
        }
        /// <summary>
        /// Cleanup this instance.
        /// </summary>
        public virtual void Cleanup(){
            
        }
    }
}
