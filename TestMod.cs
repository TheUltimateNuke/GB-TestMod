using CementTools;

namespace TestMod
{
    public class TestMod : CementMod
    {
        public void Awake()
        {
            Cement.Log(GetType().Name + " has loaded.");
        }

        public void Start()
        {
            Cement.Log(GetType().Name + " has started.");
        }

        public void Update()
        {

        }
    }
}