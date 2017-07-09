using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;
using System.Threading;
namespace Email.Toolkit
{
    public class Tool
    {
        private List<Type> currentMapper;
        private Context _currentContext;
        private IEmailHelper _emailHelper;


        public Tool(IEmailHelper emailHelper)
        {
            this.currentMapper = new List<Type>();
            this._currentContext = new Context();
            this._emailHelper = emailHelper;

        }
        /// <summary>
        /// Run this instance.
        /// </summary>
        public void Run(){
            Console.WriteLine("开始执行类。。。");
            var assembies= AppDomain.CurrentDomain.GetAssemblies();
            foreach(var assembly in assembies){ 
                currentMapper.AddRange(assembly.GetTypes().Where(s=>s.IsSubclassOf(typeof(Mapper))));
                Console.WriteLine(assembly.GetName().FullName);
            }

            foreach(var type in currentMapper){
                Mapper  map=(Mapper)type.Assembly.CreateInstance(type.FullName,true);
                try
                {
                    this._currentContext.emit += new Context.EmitHandler(SendEmail);
                    map.Map(this._currentContext);
                    //

                }catch(Exception ex){
                    
                    Console.WriteLine(type.FullName+"ss"+ex.Message+"::"+ex.StackTrace);
                }
                Console.WriteLine(type.FullName);
            }
        }

        /// <summary>
        /// 调试类(当前执行的项目程序集中)
        /// </summary>
        /// <param name="fullClassName">Full class name.</param>
        [Obsolete("有框架并不是直接卸载项目中的，不适合在项目中调试该信息，若使用请在该dll中进行调试！")]
        public void RunDebug(string fullClassName){
            Console.WriteLine("开始执行类。。。");
            Assembly assembly= Assembly.GetExecutingAssembly();
            Mapper map=(Mapper) assembly.CreateInstance(fullClassName,true);
            map.Map(this._currentContext);
        }
        /// <summary>
        /// Runs the debug.
        /// </summary>
        /// <param name="assemblyPath">Assembly path.</param>
        /// <param name="fullClassName">Full class name.</param>
        public void RunDebug(string assemblyPath, string fullClassName){
            Console.WriteLine("开始执行类。。。");
            Assembly assembly = Assembly.LoadFile(assemblyPath);
            Mapper map = (Mapper)assembly.CreateInstance(fullClassName);
            map.Map(this._currentContext);
        }
        /// <summary>
        /// Sends the email.
        /// </summary>
        /// <param name="sender">Sender.</param>
        /// <param name="e">E.</param>
        public void SendEmail(object sender,EmailEventArgs e){
            this._emailHelper.SendEmail(e.EmailEntries());
        }
    }
}
