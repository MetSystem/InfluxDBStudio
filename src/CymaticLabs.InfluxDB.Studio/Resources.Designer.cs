﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace CymaticLabs.InfluxDB.Studio {
    using System;
    
    
    /// <summary>
    ///   一个强类型的资源类，用于查找本地化的字符串等。
    /// </summary>
    // 此类是由 StronglyTypedResourceBuilder
    // 类通过类似于 ResGen 或 Visual Studio 的工具自动生成的。
    // 若要添加或移除成员，请编辑 .ResX 文件，然后重新运行 ResGen
    // (以 /str 作为命令选项)，或重新生成 VS 项目。
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   返回此类使用的缓存的 ResourceManager 实例。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CymaticLabs.InfluxDB.Studio.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   重写当前线程的 CurrentUICulture 属性，对
        ///   使用此强类型资源类的所有资源查找执行重写。
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   查找类似于 (图标) 的 System.Drawing.Icon 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Icon AppIcon1 {
            get {
                object obj = ResourceManager.GetObject("AppIcon1", resourceCulture);
                return ((System.Drawing.Icon)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap BackFill {
            get {
                object obj = ResourceManager.GetObject("BackFill", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 The destination measurement will store the results of the Back Fill.
        ///Select an existing measurement or type in the name of a new destination. 的本地化字符串。
        /// </summary>
        public static string BF_Destination_Info {
            get {
                return ResourceManager.GetString("BF_Destination_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 A comma-separated list of &quot;WHERE&quot; filters to apply to the query. 的本地化字符串。
        /// </summary>
        public static string BF_Filters_Info {
            get {
                return ResourceManager.GetString("BF_Filters_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The Back Fill&apos;s interval: 1h, 30m, 45s, etc. 的本地化字符串。
        /// </summary>
        public static string BF_Interval_Info {
            get {
                return ResourceManager.GetString("BF_Interval_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This is the source measurement for data selected by the Back Fill.
        ///Select or type in the name of the existing measurement for the query. 的本地化字符串。
        /// </summary>
        public static string BF_Source_Info {
            get {
                return ResourceManager.GetString("BF_Source_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Connection {
            get {
                object obj = ResourceManager.GetObject("Connection", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap ContinuousQuery {
            get {
                object obj = ResourceManager.GetObject("ContinuousQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 The destination measurement will store the results of the Continuous Query.
        ///Select an existing measurement or type in the name of a new destination. 的本地化字符串。
        /// </summary>
        public static string CQ_Destination_Info {
            get {
                return ResourceManager.GetString("CQ_Destination_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 how empty values will be treated using: fill() 的本地化字符串。
        /// </summary>
        public static string CQ_FillType_Info {
            get {
                return ResourceManager.GetString("CQ_FillType_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 The CQ&apos;s interval: 1h, 30m, 45s, etc. 的本地化字符串。
        /// </summary>
        public static string CQ_Interval_Info {
            get {
                return ResourceManager.GetString("CQ_Interval_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 
        ///Advance Syntax/Schedule and Coverage:
        ///
        ///CQs operate on realtime data.With the advanced syntax, CQs use the local server’s timestamp, the information in the RESAMPLE clause,
        ///and InfluxDB’s preset time boundaries to determine when to execute and what time range to cover in the query.
        ///
        ///CQs execute at the same interval as the EVERY interval in the RESAMPLE clause, and they run at the start of InfluxDB’s preset time
        ///boundaries. If the EVERY interval is two hours, InfluxDB executes the CQ at the top of eve [字符串的其余部分被截断]&quot;; 的本地化字符串。
        /// </summary>
        public static string CQ_Resample_Info {
            get {
                return ResourceManager.GetString("CQ_Resample_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use an EVERY interval in the RESAMPLE clause to specify the CQ’s execution interval. 的本地化字符串。
        /// </summary>
        public static string CQ_ResampleEvery_Info {
            get {
                return ResourceManager.GetString("CQ_ResampleEvery_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 Use a FOR interval in the RESAMPLE clause to specify the length of the CQ’s time range. 的本地化字符串。
        /// </summary>
        public static string CQ_ResampleFor_Info {
            get {
                return ResourceManager.GetString("CQ_ResampleFor_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 This is the source measurement for data selected by the Continuous Query.
        ///Select or type in the name of the existing measurement for the query. 的本地化字符串。
        /// </summary>
        public static string CQ_Source_Info {
            get {
                return ResourceManager.GetString("CQ_Source_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 CQ&apos;s need at least one subquery/downsampler to be created.
        ///To add additional subqueries/downsamplers that will run as part of the CQ,
        ///click the &quot;Add Subquery&quot; button. Click the &quot;X&quot; button on the subquery tabs
        ///to remove unwanted subqueries. 的本地化字符串。
        /// </summary>
        public static string CQ_Subquery_Info {
            get {
                return ResourceManager.GetString("CQ_Subquery_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找类似 By default, all INTO queries convert any tags in the source measurement to fields in the destination measurement.
        ///Type a comma-separated list of tag names to preserve in the destination measurement: tag1, tag2, tag3, etc. 的本地化字符串。
        /// </summary>
        public static string CQ_Tags_Info {
            get {
                return ResourceManager.GetString("CQ_Tags_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap CreateConnection {
            get {
                object obj = ResourceManager.GetObject("CreateConnection", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap CreateContinuousQuery {
            get {
                object obj = ResourceManager.GetObject("CreateContinuousQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap CreateDatabase {
            get {
                object obj = ResourceManager.GetObject("CreateDatabase", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap CreateRetentionPolicy {
            get {
                object obj = ResourceManager.GetObject("CreateRetentionPolicy", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap CreateUser {
            get {
                object obj = ResourceManager.GetObject("CreateUser", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Database {
            get {
                object obj = ResourceManager.GetObject("Database", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Date {
            get {
                object obj = ResourceManager.GetObject("Date", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Diagnostics {
            get {
                object obj = ResourceManager.GetObject("Diagnostics", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Disconnect {
            get {
                object obj = ResourceManager.GetObject("Disconnect", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropContinuousQuery {
            get {
                object obj = ResourceManager.GetObject("DropContinuousQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropDatabase {
            get {
                object obj = ResourceManager.GetObject("DropDatabase", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropMeasurement {
            get {
                object obj = ResourceManager.GetObject("DropMeasurement", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropRetentionPolicy {
            get {
                object obj = ResourceManager.GetObject("DropRetentionPolicy", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropSeries {
            get {
                object obj = ResourceManager.GetObject("DropSeries", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap DropUser {
            get {
                object obj = ResourceManager.GetObject("DropUser", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap EditConnection {
            get {
                object obj = ResourceManager.GetObject("EditConnection", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap EditPrivilege {
            get {
                object obj = ResourceManager.GetObject("EditPrivilege", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap EditRetentionPolicy {
            get {
                object obj = ResourceManager.GetObject("EditRetentionPolicy", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap EditUser {
            get {
                object obj = ResourceManager.GetObject("EditUser", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap FieldKeys {
            get {
                object obj = ResourceManager.GetObject("FieldKeys", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap GrantPrivilege {
            get {
                object obj = ResourceManager.GetObject("GrantPrivilege", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap influxdb_logo {
            get {
                object obj = ResourceManager.GetObject("influxdb_logo", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Info {
            get {
                object obj = ResourceManager.GetObject("Info", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap KillQuery {
            get {
                object obj = ResourceManager.GetObject("KillQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Measurement {
            get {
                object obj = ResourceManager.GetObject("Measurement", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap NewQuery {
            get {
                object obj = ResourceManager.GetObject("NewQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Password {
            get {
                object obj = ResourceManager.GetObject("Password", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Refresh {
            get {
                object obj = ResourceManager.GetObject("Refresh", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap RetentionPolicy {
            get {
                object obj = ResourceManager.GetObject("RetentionPolicy", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找类似 The duration of the retention policy: 1h, 30m, 45s, etc. 的本地化字符串。
        /// </summary>
        public static string RP_Duration_Info {
            get {
                return ResourceManager.GetString("RP_Duration_Info", resourceCulture);
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap RunQuery {
            get {
                object obj = ResourceManager.GetObject("RunQuery", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Series {
            get {
                object obj = ResourceManager.GetObject("Series", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap ShowQueries {
            get {
                object obj = ResourceManager.GetObject("ShowQueries", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap ShowSeries {
            get {
                object obj = ResourceManager.GetObject("ShowSeries", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Stats {
            get {
                object obj = ResourceManager.GetObject("Stats", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap TagKeys {
            get {
                object obj = ResourceManager.GetObject("TagKeys", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap TagValues {
            get {
                object obj = ResourceManager.GetObject("TagValues", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Time {
            get {
                object obj = ResourceManager.GetObject("Time", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
        
        /// <summary>
        ///   查找 System.Drawing.Bitmap 类型的本地化资源。
        /// </summary>
        public static System.Drawing.Bitmap Users {
            get {
                object obj = ResourceManager.GetObject("Users", resourceCulture);
                return ((System.Drawing.Bitmap)(obj));
            }
        }
    }
}