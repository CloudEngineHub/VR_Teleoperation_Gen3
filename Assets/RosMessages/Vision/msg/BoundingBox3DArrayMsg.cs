//Do not edit! This file was generated by Unity-ROS MessageGeneration.
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Unity.Robotics.ROSTCPConnector.MessageGeneration;

namespace RosMessageTypes.Vision
{
    [Serializable]
    public class BoundingBox3DArrayMsg : Message
    {
        public const string k_RosMessageName = "vision_msgs/BoundingBox3DArray";
        public override string RosMessageName => k_RosMessageName;

        public Std.HeaderMsg header;
        public BoundingBox3DMsg[] boxes;

        public BoundingBox3DArrayMsg()
        {
            this.header = new Std.HeaderMsg();
            this.boxes = new BoundingBox3DMsg[0];
        }

        public BoundingBox3DArrayMsg(Std.HeaderMsg header, BoundingBox3DMsg[] boxes)
        {
            this.header = header;
            this.boxes = boxes;
        }

        public static BoundingBox3DArrayMsg Deserialize(MessageDeserializer deserializer) => new BoundingBox3DArrayMsg(deserializer);

        private BoundingBox3DArrayMsg(MessageDeserializer deserializer)
        {
            this.header = Std.HeaderMsg.Deserialize(deserializer);
            deserializer.Read(out this.boxes, BoundingBox3DMsg.Deserialize, deserializer.ReadLength());
        }

        public override void SerializeTo(MessageSerializer serializer)
        {
            serializer.Write(this.header);
            serializer.WriteLength(this.boxes);
            serializer.Write(this.boxes);
        }

        public override string ToString()
        {
            return "BoundingBox3DArrayMsg: " +
            "\nheader: " + header.ToString() +
            "\nboxes: " + System.String.Join(", ", boxes.ToList());
        }

#if UNITY_EDITOR
        [UnityEditor.InitializeOnLoadMethod]
#else
        [UnityEngine.RuntimeInitializeOnLoadMethod]
#endif
        public static void Register()
        {
            MessageRegistry.Register(k_RosMessageName, Deserialize);
        }
    }
}
