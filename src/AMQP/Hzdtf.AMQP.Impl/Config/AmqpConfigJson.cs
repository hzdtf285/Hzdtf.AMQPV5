using Hzdtf.AMQP.Contract.Config;
using Hzdtf.AMQP.Model.Config;
using Hzdtf.Utility.Attr;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hzdtf.AMQP.Impl.Config
{
    /// <summary>
    /// AMQP配置JSON文件
    /// @ 黄振东
    /// </summary>
    [Inject]
    public class AmqpConfigJson : IAmqpConfigReader
    {
        /// <summary>
        /// 配置JSON文件
        /// </summary>
        private readonly string configJsonFile;

        /// <summary>
        /// 构造方法，默认读取amqp.json
        /// </summary>
        public AmqpConfigJson()
            : this("amqp.json")
        { }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="configJsonFile">配置JSON文件</param>
        public AmqpConfigJson(string configJsonFile) 
        {
            this.configJsonFile = configJsonFile;
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <returns>数据</returns>
        public AmqpConfigInfo Reader()
        {
            return configJsonFile.ToJsonObjectFromFile<AmqpConfigInfo>(); 
        }
    }
}
