using UnityEngine;
using socket.io;

namespace Sample {

    /// <summary>
    /// The basic sample to show how to connect to a server
    /// </summary>
    public class Connect : MonoBehaviour {
        Socket socket;

        void Start() {
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


        public void ServerStatus()
        {
            Debug.Log(socket.IsConnected);

        }

    }

}
