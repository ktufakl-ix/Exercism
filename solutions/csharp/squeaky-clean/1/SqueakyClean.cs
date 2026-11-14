using System.Text;

public static class Identifier
{
    public static string Clean(string identifier)
    {
        // 使用 StringBuilder 来逐字符构建结果，避免频繁创建新字符串。
        var builder = new StringBuilder();

        // 逐个检查输入字符串中的每个字符。
        for (var i = 0; i < identifier.Length; i++)
        {
            var current = identifier[i];

            // 1. 把空格替换为下划线。
            if (current == ' ')
            {
                builder.Append('_');
            }
            // 2. 把控制字符替换为 "CTRL"。
            else if (char.IsControl(current))
            {
                builder.Append("CTRL");
            }
            // 3. 忽略连字符，后续会把它后面的字符转换为大写，形成 camelCase。
            else if (current == '-')
            {
                continue;
            }
            // 4. 忽略希腊小写字母（α 到 ω）。
            else if (current >= 'α' && current <= 'ω')
            {
                continue;
            }
            // 5. 只保留字母，并在连字符后面的大写字母上做大小写转换。
            else if (char.IsLetter(current))
            {
                if (i > 0 && identifier[i - 1] == '-')
                {
                    builder.Append(char.ToUpper(current));
                }
                else
                {
                    builder.Append(current);
                }
            }
        }

        // 返回组装好的清理结果。
        return builder.ToString();
    }
}
