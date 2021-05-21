using System.IO;
using System.Diagnostics;
using System.Text;
using System;

namespace c_sharp_nvelocity
{
    class Program
    {
        static void Main(string[] args)
        {
            // 初期処理
            NVelocity.App.Velocity.Init();
            // コンテキストを生成する
            NVelocity.VelocityContext context = new NVelocity.VelocityContext();
            // 変数と値の組み合わせを格納する
            context.Put("name", "hoge");
            // テンプレートファイルを指定してテキストを生成する
            StringBuilder sb = new StringBuilder();
            using (StringWriter writer = new StringWriter(sb))
            {
                // NVelocity.App.Velocity.MergeTemplate("test.vm", "utf-8", context, writer);
                NVelocity.App.Velocity.MergeTemplate("test.xml.vm", "utf-8", context, writer);
            }
            Debug.WriteLine(sb.ToString());
        }
    }
}
