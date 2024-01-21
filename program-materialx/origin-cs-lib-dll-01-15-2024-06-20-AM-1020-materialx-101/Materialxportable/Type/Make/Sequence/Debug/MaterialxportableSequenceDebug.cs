using Core;

namespace Core
{
    using System;

    public partial class MaterialxportableSequence
    {
        public static void Debug(Materialxportablestringarraysafe RouteIdentity__VALUE,  Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var join = String.Join('\n'.ToString(), new String[] {
            
                String.Empty + nameof(Materialxportable) + ' ' + "::" + ' ' + nameof(MaterialxportableSequence) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(RouteIdentity__VALUE) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(RouteIdentity__VALUE) + ':',
                String.Empty + $"<safe><<{String.Join(','.ToString(), RouteIdentity__VALUE.ValueSafe)}>>"
            });

            Materialxportablerender.GroupRender($"{MaterialxportableCode.RenderPath.Core_Materialxportable_Debug}", join);

            return;
        }
    }
}
