using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class networkCommandLine : MonoBehaviour
{
    private NetworkManager NetMan;
    // Start is called before the first frame update
    void Start()
    {
        NetMan = GetComponentInParent<NetworkManager>();
        if (Application.isEditor) return;
        var Args = GetCommandlineArgs();
        if (Args.TryGetValue("-mode",out string mode))
        {
            switch (mode)
            {
                case "server":
                    NetMan.StartServer();
                    break;
                case "host":
                    NetMan.StartHost();
                    break;
                case "client":
                    NetMan.StartClient();
                    break;
            }
        }
    }

    // Update is called once per frame
    private Dictionary<string,string> GetCommandlineArgs()
    {
        Dictionary<string, string> ArgD = new Dictionary<string, string>();
        var Args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < Args.Length; ++i)
        {
            var Arg = Args[i].ToLower();
            if (Arg.StartsWith("-"))
            {
                
                var value = i < Args.Length - 1 ? Args[i + 1].ToLower() : null;
                value = (value?.StartsWith("-")?? false)? null : value;
                ArgD.Add(Arg, value);

            }
        }
        return ArgD;
    }
}
