﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ChatGPT_client.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        /// <summary>
        /// ID of the model to use.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("ID of the model to use.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("text-davinci-003")]
        public string model {
            get {
                return ((string)(this["model"]));
            }
            set {
                this["model"] = value;
            }
        }
        
        /// <summary>
        /// The suffix that comes after a completion of inserted text.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The suffix that comes after a completion of inserted text.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("null")]
        public string suffix {
            get {
                return ((string)(this["suffix"]));
            }
            set {
                this["suffix"] = value;
            }
        }
        
        /// <summary>
        /// The maximum number of tokens to generate in the completion.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("The maximum number of tokens to generate in the completion.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("4000")]
        public int max_tokens {
            get {
                return ((int)(this["max_tokens"]));
            }
            set {
                this["max_tokens"] = value;
            }
        }
        
        /// <summary>
        /// What sampling temperature to use. Higher values means the model will take more risks. Try 0.9 for more creative applications, and 0 (argmax sampling) for ones with a well-defined answer.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("What sampling temperature to use. Higher values means the model will take more ri" +
            "sks. Try 0.9 for more creative applications, and 0 (argmax sampling) for ones wi" +
            "th a well-defined answer.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal temperature {
            get {
                return ((decimal)(this["temperature"]));
            }
            set {
                this["temperature"] = value;
            }
        }
        
        /// <summary>
        /// An alternative to sampling with temperature, called nucleus sampling, where the model considers the results of the tokens with top_p probability mass. So 0.1 means only the tokens comprising the top 10% probability mass are considered.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("An alternative to sampling with temperature, called nucleus sampling, where the m" +
            "odel considers the results of the tokens with top_p probability mass. So 0.1 mea" +
            "ns only the tokens comprising the top 10% probability mass are considered.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public decimal top_p {
            get {
                return ((decimal)(this["top_p"]));
            }
            set {
                this["top_p"] = value;
            }
        }
        
        /// <summary>
        /// How many completions to generate for each prompt.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("How many completions to generate for each prompt.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int n {
            get {
                return ((int)(this["n"]));
            }
            set {
                this["n"] = value;
            }
        }
        
        /// <summary>
        /// Whether to stream back partial progress. If set, tokens will be sent as data-only server-sent events as they become available, with the stream terminated by a data: [DONE] message.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Whether to stream back partial progress. If set, tokens will be sent as data-only" +
            " server-sent events as they become available, with the stream terminated by a da" +
            "ta: [DONE] message.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool stream {
            get {
                return ((bool)(this["stream"]));
            }
            set {
                this["stream"] = value;
            }
        }
        
        /// <summary>
        /// Echo back the prompt in addition to the completion.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Echo back the prompt in addition to the completion.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool echo {
            get {
                return ((bool)(this["echo"]));
            }
            set {
                this["echo"] = value;
            }
        }
        
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on whether they appear in the text so far, increasing the model&apos;s likelihood to talk about new topics.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number between -2.0 and 2.0. Positive values penalize new tokens based on whether" +
            " they appear in the text so far, increasing the model\'s likelihood to talk about" +
            " new topics.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0")]
        public decimal presence_penalty {
            get {
                return ((decimal)(this["presence_penalty"]));
            }
            set {
                this["presence_penalty"] = value;
            }
        }
        
        /// <summary>
        /// Number between -2.0 and 2.0. Positive values penalize new tokens based on their existing frequency in the text so far, decreasing the model&apos;s likelihood to repeat the same line verbatim.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Number between -2.0 and 2.0. Positive values penalize new tokens based on their e" +
            "xisting frequency in the text so far, decreasing the model\'s likelihood to repea" +
            "t the same line verbatim.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0")]
        public decimal frequency_penalty {
            get {
                return ((decimal)(this["frequency_penalty"]));
            }
            set {
                this["frequency_penalty"] = value;
            }
        }
        
        /// <summary>
        /// Generates best_of completions server-side and returns the &quot;best&quot; (the one with the highest log probability per token). Results cannot be streamed.
        /// </summary>
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Configuration.SettingsDescriptionAttribute("Generates best_of completions server-side and returns the \"best\" (the one with th" +
            "e highest log probability per token). Results cannot be streamed.")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int best_of {
            get {
                return ((int)(this["best_of"]));
            }
            set {
                this["best_of"] = value;
            }
        }
    }
}