using System;
namespace Email.Toolkit
{
    public abstract class Mapper
    {

        /// <summary>
        /// 配置邮件是否发送
        /// </summary>
        /// <returns>The Step.</returns>
        public virtual bool Step(){
            return false;
        }

        /// <summary>
        /// 所有邮件自定义
        /// </summary>
        public virtual void Map(Context context){
            
        }

        /// <summary>
        /// Cleans up.
        /// </summary>
        public virtual void CleanUp(){
            Console.Write("clean up base menthod");
        }
    }
}
