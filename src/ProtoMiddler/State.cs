using System.Configuration;
using System.Diagnostics;

namespace ProtoMiddler
{
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public class State : ApplicationSettingsBase
    {
        [UserScopedSettingAttribute]
        [DebuggerNonUserCode]
        [DefaultSettingValueAttribute("")]
        public string ProtoPath
        {
            get
            {
                return ((string)(this["ProtoPath"]));
            }
            set
            {
                this["ProtoPath"] = value;
            }
        }

        [UserScopedSettingAttribute]
        [DebuggerNonUserCodeAttribute]
        [DefaultSettingValueAttribute("")]
        public string ProtoFile
        {
            get
            {
                return ((string)(this["ProtoFile"]));
            }
            set
            {
                this["ProtoFile"] = value;
            }
        }
    }

    public class RequestState : State
    {
        public static readonly RequestState Default = ((RequestState)(Synchronized(new RequestState())));
    }

    public class ResponseState : State
    {
        public static readonly ResponseState Default = ((ResponseState)(Synchronized(new ResponseState())));
    }
}
