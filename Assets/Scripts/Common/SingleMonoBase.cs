
namespace CloudX{

        public class SingleMonoBase<T> : MonoBehaviour where T : MonoBehaviour{
                //基于unity框架的单例模式：当脚本被赋值给某一个GameObject的时候，实际上就已经完成了new对象
                private static T instance;
                private GameObject MonoSingletionRoot;
                private string MonoSingletionRootName="MonoSingletionRoot";

                public static Instance{

                        get{
                            MonoSingletionRoot=GameObject.Find(MonoSingletionRootName);

                            if(MonoSingletionRoot==null){
                                MonoSingletionRoot=new GameObject();
                                MonoSingletionRoot.name=MonoSingletionRootName;
                            }


                            if(instance==null){
                                
                               instance= MonoSingletionRoot.GetComponent<T>();
                                if(instance==null){
                                    instance=MonoSingletionRoot.gameObject.AddComponent<T>();
                                }

                            }
                            return instance;
                        }
                }

        }



















}

