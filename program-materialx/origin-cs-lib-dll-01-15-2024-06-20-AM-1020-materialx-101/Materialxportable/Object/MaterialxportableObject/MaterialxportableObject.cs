using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Materialxportable
    {
        [Materialxportableism]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Materialxportable) + ' ' + "::" + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(RouteIdentity) + ':' + ' ' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(SegmentArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Materialxportable[])SegmentArrayObject).Length}>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(ObjectIdentity) + ':' + ' ' + ". . ." + ' ' + $"<{ObjectIdentity == default}>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(RemoteArrayObject) + ':' + ' ' + ". . ." + ' ' + $"<{((Byte[])RemoteArrayObject).Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + ". . . . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(RouteIdentity) + ':',
                String.Empty + $"<safe><<{String.Join(','.ToString(), ((Materialxportablestringarraysafe)RouteIdentity).ValueSafe)}>>",
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(SegmentArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (IEnumerable<Materialxportable>)SegmentArrayObject),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(ObjectIdentity) + ':',
                String.Empty + ObjectIdentity,
                String.Empty,
                String.Empty + '~' + "40" + ' ' + nameof(RemoteArrayObject) + ':',
                String.Empty + String.Join('\n'.ToString(), (Byte[])RemoteArrayObject),
                String.Empty,
                String.Empty + '~' + "50" + ' ' + ". . . . .",
                String.Empty + Materialxportableformat.RepresentString(this, 1)
            });
        }
    }
}
