using System.Reflection;
using UnityEngine;

namespace Kogane
{
    public static class EventInternal
    {
        public static Event GetCurrent()
        {
            var fieldInfo = typeof( Event ).GetField
            (
                name: "s_Current",
                bindingAttr: BindingFlags.Static | BindingFlags.NonPublic
            );

            return ( Event )fieldInfo.GetValue( null );
        }
    }
}