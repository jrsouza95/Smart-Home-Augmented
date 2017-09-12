using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using socket.io;



public class ioContect : MonoBehaviour {
    Socket socket;
    bool on = false;

    void Start()
    {
        var serverUrl = "http://192.168.1.99:8245";
        socket = Socket.Connect(serverUrl);

        socket.On(SystemEvents.connect, () => {
            Debug.Log("Hello, Socket.io~");

        });

        socket.On(SystemEvents.reconnect, (int reconnectAttempt) => {
            Debug.Log("Hello, Again! " + reconnectAttempt);

        });

        socket.On(SystemEvents.disconnect, () => {
            Debug.Log("Bye~");

        });
    }

    public void SwithLight(string light) {
        Debug.Log(socket.IsConnected);

        
        socket.Emit("lamp_All", light) ;
    }

}

