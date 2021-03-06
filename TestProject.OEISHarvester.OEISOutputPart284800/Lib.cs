using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A183635
{
public static readonly long[] Value={ 136L,340L,952L,2884L,9256L,31060L,107992L,386404L,1415176L,5281780L,20015032L,76773124L,297329896L,1160228500L,4554034072L,17956283044L,71047145416L,281857767220L,1120444917112L,4460833796164L,17780522733736L,70933703913940L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183635Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183635.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183635Inst : IEnumerable<long>
{
public static readonly long[] Value=A183635.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183635.Bytes);
public long this[int i]=>Value[i];

public static A183635Inst Instance=new A183635Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183636
{
public static readonly long[] Value={ 452L,952L,2300L,6136L,17612L,53512L,170300L,563416L,1926572L,6776872L,24422300L,89839096L,336216332L,1276265032L,4900898300L,18994385176L,74156470892L,291175781992L,1148379038300L,4544596313656L,18031730594252L,71687168111752L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183636Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183636.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183636Inst : IEnumerable<long>
{
public static readonly long[] Value=A183636.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183636.Bytes);
public long this[int i]=>Value[i];

public static A183636Inst Instance=new A183636Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183637
{
public static readonly long[] Value={ 1576L,2884L,6136L,14644L,38056L,105604L,309016L,945364L,3004936L,9877924L,33458296L,116413684L,414874216L,1510107844L,5598165976L,21077667604L,80389277896L,309840123364L,1204303904056L,4712234595124L,18534372807976L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183637Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183637.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183637Inst : IEnumerable<long>
{
public static readonly long[] Value=A183637.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183637.Bytes);
public long this[int i]=>Value[i];

public static A183637Inst Instance=new A183637Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183638
{
public static readonly long[] Value={ 5684L,9256L,17612L,38056L,90524L,231736L,629132L,1793416L,5328764L,16413016L,52195052L,170891176L,574845404L,1983103096L,7003319372L,25265467336L,92897360444L,347253741976L,1316323506092L,5047850897896L,19540336713884L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183638Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183638.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183638Inst : IEnumerable<long>
{
public static readonly long[] Value=A183638.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183638.Bytes);
public long this[int i]=>Value[i];

public static A183638Inst Instance=new A183638Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183639
{
public static readonly long[] Value={ 21016L,31060L,53512L,105604L,231736L,551380L,1398952L,3743524L,10479256L,30483700L,91664392L,283832644L,902755576L,2945024020L,9845481832L,33704772964L,118040932696L,422335788340L,1540872323272L,5720102724484L,21554302962616L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183639Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183639.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183639Inst : IEnumerable<long>
{
public static readonly long[] Value=A183639.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183639.Bytes);
public long this[int i]=>Value[i];

public static A183639Inst Instance=new A183639Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183640
{
public static readonly long[] Value={ 79172L,107992L,170300L,309016L,629132L,1398952L,3333500L,8411896L,22294892L,61632712L,176596700L,521681176L,1582485452L,4916663272L,15625379900L,50774508856L,168710304812L,573264314632L,1991498803100L,7067664046936L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183640Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183640.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183640Inst : IEnumerable<long>
{
public static readonly long[] Value=A183640.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183640.Bytes);
public long this[int i]=>Value[i];

public static A183640Inst Instance=new A183640Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183641
{
public static readonly long[] Value={ 302536L,386404L,563416L,945364L,1793416L,3743524L,8411896L,20077684L,50494696L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183641Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183641.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183641Inst : IEnumerable<long>
{
public static readonly long[] Value=A183641.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183641.Bytes);
public long this[int i]=>Value[i];

public static A183641Inst Instance=new A183641Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183642
{
public static readonly long[] Value={ 44L,136L,136L,452L,340L,452L,1576L,952L,952L,1576L,5684L,2884L,2300L,2884L,5684L,21016L,9256L,6136L,6136L,9256L,21016L,79172L,31060L,17612L,14644L,17612L,31060L,79172L,302536L,107992L,53512L,38056L,38056L,53512L,107992L,302536L,1168724L,386404L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183642Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183642.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183642Inst : IEnumerable<long>
{
public static readonly long[] Value=A183642.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183642.Bytes);
public long this[int i]=>Value[i];

public static A183642Inst Instance=new A183642Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A183643
{
public static readonly long[] Value={ 85L,1001L,10213L,97145L,889525L,7969001L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A183643Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A183643.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A183643Inst : IEnumerable<long>
{
public static readonly long[] Value=A183643.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A183643.Bytes);
public long this[int i]=>Value[i];

public static A183643Inst Instance=new A183643Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184332
{
public static readonly long[] Value={ 3L,5L,8L,11L,12L,15L,16L,20L,21L,25L,26L,28L,31L,32L,34L,37L,39L,41L,44L,46L,48L,50L,52L,54L,56L,58L,60L,62L,65L,67L,69L,71L,74L,76L,78L,79L,81L,84L,86L,88L,89L,91L,94L,97L,99L,100L,102L,105L,108L,110L,111L,113L,114L,117L,120L,122L,123L,125L,126L,129L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184332Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184332.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184332Inst : IEnumerable<long>
{
public static readonly long[] Value=A184332.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184332.Bytes);
public long this[int i]=>Value[i];

public static A184332Inst Instance=new A184332Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184333
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,13L,14L,17L,18L,19L,22L,23L,24L,27L,29L,30L,33L,35L,36L,38L,40L,42L,43L,45L,47L,49L,51L,53L,55L,57L,59L,61L,63L,64L,66L,68L,70L,72L,73L,75L,77L,80L,82L,83L,85L,87L,90L,92L,93L,95L,96L,98L,101L,103L,104L,106L,107L,109L,112L,115L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184333Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184333.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184333Inst : IEnumerable<long>
{
public static readonly long[] Value=A184333.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184333.Bytes);
public long this[int i]=>Value[i];

public static A184333Inst Instance=new A184333Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184334
{
public static readonly long[] Value={ 1L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L,2L,2L,0L,-2L,-2L,0L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184334Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184334.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184334Inst : IEnumerable<long>
{
public static readonly long[] Value=A184334.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184334.Bytes);
public long this[int i]=>Value[i];

public static A184334Inst Instance=new A184334Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184335
{
public static readonly long[] Value={ 4L,6L,10L,14L,20L,22L,26L,28L,34L,38L,42L,44L,46L,50L,58L,62L,74L,75L,76L,78L,82L,86L,90L,92L,94L,106L,114L,118L,122L,124L,125L,134L,135L,142L,146L,158L,166L,172L,178L,186L,188L,194L,202L,204L,206L,214L,218L,222L,226L,236L,254L,258L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184335Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184335.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184335Inst : IEnumerable<long>
{
public static readonly long[] Value=A184335.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184335.Bytes);
public long this[int i]=>Value[i];

public static A184335Inst Instance=new A184335Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184336
{
public static readonly long[] Value={ 1L,3L,4L,5L,6L,7L,9L,10L,11L,12L,13L,14L,15L,16L,17L,18L,20L,21L,22L,23L,24L,25L,26L,27L,28L,29L,30L,31L,32L,33L,34L,35L,36L,38L,39L,40L,41L,42L,43L,44L,45L,46L,47L,48L,49L,50L,51L,52L,53L,54L,55L,56L,57L,58L,59L,60L,61L,62L,63L,64L,66L,67L,68L,69L,70L,71L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184336Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184336.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184336Inst : IEnumerable<long>
{
public static readonly long[] Value=A184336.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184336.Bytes);
public long this[int i]=>Value[i];

public static A184336Inst Instance=new A184336Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184337
{
public static readonly BigInteger[] Value={ 0L,81L,8811L,888111L,88881111L,8888811111L,888888111111L,88888881111111L,8888888811111111L,888888888111111111L,BigInteger.Parse("88888888881111111111"),BigInteger.Parse("8888888888811111111111"),BigInteger.Parse("888888888888111111111111"),BigInteger.Parse("88888888888881111111111111") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184337Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184337.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184337Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184337.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184337.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184337Inst Instance=new A184337Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184338
{
public static readonly long[] Value={ 4L,3L,2L,4L,1L,3L,4L,2L,4L,3L,1L,2L,3L,4L,2L,1L,4L,3L,4L,1L,2L,3L,4L,3L,2L,1L,4L,2L,3L,4L,1L,2L,3L,1L,4L,3L,2L,4L,1L,4L,2L,3L,4L,1L,3L,2L,3L,1L,4L,2L,3L,2L,4L,1L,4L,2L,3L,1L,4L,1L,3L,2L,4L,3L,1L,4L,2L,3L,2L,4L,1L,3L,4L,2L,3L,1L,4L,2L,1L,3L,2L,4L,3L,1L,4L,2L,3L,1L,2L,4L,1L,3L,4L,2L,4L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184338Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184338.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184338Inst : IEnumerable<long>
{
public static readonly long[] Value=A184338.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184338.Bytes);
public long this[int i]=>Value[i];

public static A184338Inst Instance=new A184338Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184339
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,7L,45L,1371L,14366L,193997L,3094797L,51673672L,934142475L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184339Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184339.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184339Inst : IEnumerable<long>
{
public static readonly long[] Value=A184339.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184339.Bytes);
public long this[int i]=>Value[i];

public static A184339Inst Instance=new A184339Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184340
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,1L,1L,1L,1L,1L,1L,1L,1L,2L,1L,2L,1L,4L,2L,6L,1L,10L,1L,11L,1L,15L,1L,10L,1L,20L,1L,40L,1L,42L,3L,64L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184340Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184340.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184340Inst : IEnumerable<long>
{
public static readonly long[] Value=A184340.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184340.Bytes);
public long this[int i]=>Value[i];

public static A184340Inst Instance=new A184340Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184341
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,1L,2L,2L,2L,1L,9L,1L,11L,1L,23L,2L,47L,3L,123L,80L,262L,990L,767L,9273L,3984L,68257L,29667L,424702L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184341Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184341.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184341Inst : IEnumerable<long>
{
public static readonly long[] Value=A184341.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184341.Bytes);
public long this[int i]=>Value[i];

public static A184341Inst Instance=new A184341Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184342
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,2L,1L,4L,2L,25L,2L,71L,92L,184L,1632L,1057L,20398L,11743L,195759L,143498L,1579976L,1504704L,11198739L,13454232L,71662966L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184342Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184342.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184342Inst : IEnumerable<long>
{
public static readonly long[] Value=A184342.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184342.Bytes);
public long this[int i]=>Value[i];

public static A184342Inst Instance=new A184342Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184343
{
public static readonly long[] Value={ 1L,1L,1L,1L,3L,1L,5L,2L,20L,45L,111L,998L,915L,15718L,14778L,191897L,241229L,1937847L,3273330L,17102347L,37393151L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184343Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184343.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184343Inst : IEnumerable<long>
{
public static readonly long[] Value=A184343.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184343.Bytes);
public long this[int i]=>Value[i];

public static A184343Inst Instance=new A184343Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184344
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,9L,26L,79L,860L,1039L,15799L,24210L,222885L,480909L,2649008L,7803307L,27963791L,106837398L,276117812L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184344Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184344.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184344Inst : IEnumerable<long>
{
public static readonly long[] Value=A184344.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184344.Bytes);
public long this[int i]=>Value[i];

public static A184344Inst Instance=new A184344Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184345
{
public static readonly long[] Value={ 1L,1L,2L,1L,4L,7L,17L,200L,353L,4751L,9857L,83181L,252001L,1229378L,5152888L,16936394L,88336546L,241607686L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184345Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184345.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184345Inst : IEnumerable<long>
{
public static readonly long[] Value=A184345.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184345.Bytes);
public long this[int i]=>Value[i];

public static A184345Inst Instance=new A184345Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184346
{
public static readonly long[] Value={ 1L,1L,2L,1L,7L,16L,45L,628L,1612L,14387L,52539L,275568L,1397560L,5222290L,30835346L,108322293L,606465366L,2386082882L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184346Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184346.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184346Inst : IEnumerable<long>
{
public static readonly long[] Value=A184346.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184346.Bytes);
public long this[int i]=>Value[i];

public static A184346Inst Instance=new A184346Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184347
{
public static readonly long[] Value={ 1L,1L,2L,2L,8L,47L,124L,1371L,5439L,34449L,189065L,862990L,5437663L,23939996L,139734236L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184347Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184347.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184347Inst : IEnumerable<long>
{
public static readonly long[] Value=A184347.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184347.Bytes);
public long this[int i]=>Value[i];

public static A184347Inst Instance=new A184347Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184588
{
public static readonly long[] Value={ 2L,3L,5L,7L,8L,10L,11L,13L,15L,16L,18L,19L,21L,22L,24L,26L,27L,29L,30L,32L,34L,35L,37L,38L,40L,41L,43L,45L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,68L,70L,71L,73L,75L,76L,78L,79L,81L,83L,84L,86L,87L,89L,90L,92L,94L,95L,97L,98L,100L,102L,103L,105L,106L,108L,109L,111L,113L,114L,116L,117L,119L,121L,122L,124L,125L,127L,128L,130L,132L,133L,135L,136L,138L,140L,141L,143L,144L,146L,147L,149L,151L,152L,154L,155L,157L,158L,160L,162L,163L,165L,166L,168L,170L,171L,173L,174L,176L,177L,179L,181L,182L,184L,185L,187L,189L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184588Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184588.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184588Inst : IEnumerable<long>
{
public static readonly long[] Value=A184588.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184588.Bytes);
public long this[int i]=>Value[i];

public static A184588Inst Instance=new A184588Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184589
{
public static readonly long[] Value={ 1L,4L,7L,9L,12L,15L,18L,20L,23L,26L,28L,31L,34L,37L,39L,42L,45L,47L,50L,53L,56L,58L,61L,64L,66L,69L,72L,75L,77L,80L,83L,85L,88L,91L,94L,96L,99L,102L,105L,107L,110L,113L,115L,118L,121L,124L,126L,129L,132L,134L,137L,140L,143L,145L,148L,151L,153L,156L,159L,162L,164L,167L,170L,172L,175L,178L,181L,183L,186L,189L,191L,194L,197L,200L,202L,205L,208L,211L,213L,216L,219L,221L,224L,227L,230L,232L,235L,238L,240L,243L,246L,249L,251L,254L,257L,259L,262L,265L,268L,270L,273L,276L,278L,281L,284L,287L,289L,292L,295L,298L,300L,303L,306L,308L,311L,314L,317L,319L,322L,325L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184589Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184589.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184589Inst : IEnumerable<long>
{
public static readonly long[] Value=A184589.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184589.Bytes);
public long this[int i]=>Value[i];

public static A184589Inst Instance=new A184589Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184590
{
public static readonly long[] Value={ 2L,3L,5L,6L,8L,10L,11L,13L,14L,16L,17L,19L,21L,22L,24L,25L,27L,29L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,52L,54L,55L,57L,59L,60L,62L,63L,65L,67L,68L,70L,71L,73L,74L,76L,78L,79L,81L,82L,84L,86L,87L,89L,90L,92L,93L,95L,97L,98L,100L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,120L,122L,123L,125L,127L,128L,130L,131L,133L,135L,136L,138L,139L,141L,142L,144L,146L,147L,149L,150L,152L,154L,155L,157L,158L,160L,161L,163L,165L,166L,168L,169L,171L,173L,174L,176L,177L,179L,180L,182L,184L,185L,187L,188L,190L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184590Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184590.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184590Inst : IEnumerable<long>
{
public static readonly long[] Value=A184590.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184590.Bytes);
public long this[int i]=>Value[i];

public static A184590Inst Instance=new A184590Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184591
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,11L,13L,16L,18L,20L,22L,24L,26L,28L,31L,33L,35L,37L,39L,41L,43L,46L,48L,50L,52L,54L,56L,58L,61L,63L,65L,67L,69L,71L,73L,76L,78L,80L,82L,84L,86L,88L,91L,93L,95L,97L,99L,101L,103L,106L,108L,110L,112L,114L,116L,118L,121L,123L,125L,127L,129L,131L,133L,136L,138L,140L,142L,144L,146L,148L,151L,153L,155L,157L,159L,161L,163L,166L,168L,170L,172L,174L,176L,178L,181L,183L,185L,187L,189L,191L,193L,196L,198L,200L,202L,204L,206L,208L,211L,213L,215L,217L,219L,221L,223L,226L,228L,230L,232L,234L,236L,238L,240L,243L,245L,247L,249L,251L,253L,255L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184591Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184591.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184591Inst : IEnumerable<long>
{
public static readonly long[] Value=A184591.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184591.Bytes);
public long this[int i]=>Value[i];

public static A184591Inst Instance=new A184591Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184592
{
public static readonly long[] Value={ 2L,4L,6L,8L,10L,12L,14L,15L,17L,19L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,40L,42L,44L,45L,47L,49L,51L,53L,55L,57L,59L,60L,62L,64L,66L,68L,70L,72L,74L,75L,77L,79L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,100L,102L,104L,105L,107L,109L,111L,113L,115L,117L,119L,120L,122L,124L,126L,128L,130L,132L,134L,135L,137L,139L,141L,143L,145L,147L,149L,150L,152L,154L,156L,158L,160L,162L,164L,165L,167L,169L,171L,173L,175L,177L,179L,180L,182L,184L,186L,188L,190L,192L,194L,195L,197L,199L,201L,203L,205L,207L,209L,210L,212L,214L,216L,218L,220L,222L,224L,225L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184592Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184592.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184592Inst : IEnumerable<long>
{
public static readonly long[] Value=A184592.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184592.Bytes);
public long this[int i]=>Value[i];

public static A184592Inst Instance=new A184592Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184593
{
public static readonly long[] Value={ 3L,5L,5L,3L,7L,9L,7L,3L,5L,1L,5L,3L,7L,9L,7L,9L,5L,9L,7L,11L,13L,9L,11L,7L,5L,9L,11L,9L,5L,7L,5L,9L,7L,3L,-1L,3L,1L,3L,1L,3L,-1L,3L,7L,9L,7L,3L,7L,9L,7L,3L,5L,1L,5L,9L,7L,9L,5L,9L,7L,11L,13L,15L,13L,17L,19L,17L,21L,19L,17L,13L,15L,11L,9L,11L,7L,9L,5L,3L,7L,3L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184593Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184593.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184593Inst : IEnumerable<long>
{
public static readonly long[] Value=A184593.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184593.Bytes);
public long this[int i]=>Value[i];

public static A184593Inst Instance=new A184593Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184594
{
public static readonly long[] Value={ 1L,2L,5L,6L,20L,21L,35L,62L,64L,65L,67L,97L,159L,198L,267L,444L,449L,499L,761L,764L,800L,801L,802L,803L,804L,810L,886L,1413L,1435L,1613L,1614L,1615L,1634L,2566L,2568L,4162L,4653L,6115L,6118L,6120L,6121L,6124L,6136L,7063L,7070L,7071L,7075L,7076L,7118L,7119L,7424L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184594Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184594.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184594Inst : IEnumerable<long>
{
public static readonly long[] Value=A184594.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184594.Bytes);
public long this[int i]=>Value[i];

public static A184594Inst Instance=new A184594Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184595
{
public static readonly BigInteger[] Value={ 2L,24L,1986L,782948L,1291076970L,8783684627835L,245608218357699105L,BigInteger.Parse("28056029360014523631654"),BigInteger.Parse("13030390694954764597618159782") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184595Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184595.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184595Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184595.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184595.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184595Inst Instance=new A184595Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184596
{
public static readonly long[] Value={ 2L,5L,16L,58L,214L,784L,2880L,10704L,40264L,152728L,582424L,2229856L,8566528L,33011680L,127553920L,493989568L,1916920384L,7451582080L,29011376256L,113108257920L,441536615296L,1725575305600L,6750738252160L,26435046548992L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184596Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184596.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184596Inst : IEnumerable<long>
{
public static readonly long[] Value=A184596.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184596.Bytes);
public long this[int i]=>Value[i];

public static A184596Inst Instance=new A184596Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184597
{
public static readonly long[] Value={ 5L,24L,156L,1123L,8268L,60569L,446426L,3333345L,25146354L,190958245L,1457049922L,11161985897L,85804483994L,661561762629L,5113755311738L,39616036230913L,307500608317658L,2390939974122621L,18619094389326362L,145193529732807545L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184597Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184597.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184597Inst : IEnumerable<long>
{
public static readonly long[] Value=A184597.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184597.Bytes);
public long this[int i]=>Value[i];

public static A184597Inst Instance=new A184597Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184598
{
public static readonly long[] Value={ 16L,156L,1986L,28192L,411825L,6045460L,89538170L,1339793447L,20215904926L,306972320468L,4684471214542L,71777709052696L,1103593885196101L,17017816693554841L,263086943851348011L,4076187315351054647L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184598Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184598.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184598Inst : IEnumerable<long>
{
public static readonly long[] Value=A184598.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184598.Bytes);
public long this[int i]=>Value[i];

public static A184598Inst Instance=new A184598Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184599
{
public static readonly BigInteger[] Value={ 58L,1123L,28192L,782948L,22581061L,661355087L,19597196907L,586441134417L,17688240987365L,536871796215114L,16377770252298658L,501706560946729804L,15422847845337959631UL,BigInteger.Parse("475525543795160585979"),BigInteger.Parse("14699379057329857140441") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184599Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184599.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184599Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184599.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184599.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184599Inst Instance=new A184599Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184600
{
public static readonly BigInteger[] Value={ 214L,8268L,411825L,22581061L,1291076970L,75369979530L,4461217004146L,266823559411796L,16087490826015621L,976144514798586404L,BigInteger.Parse("59534845819156963374"),BigInteger.Parse("3646426116234905396563"),BigInteger.Parse("224132828382262166503511") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184600Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184600.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184600Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184600.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184600.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184600Inst Instance=new A184600Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184601
{
public static readonly BigInteger[] Value={ 784L,60569L,6045460L,661355087L,75369979530L,8783684627835L,1038876920232926L,124201308194651058L,14971003403040041129UL,BigInteger.Parse("1816251101842544994491"),BigInteger.Parse("221492117754765269030948"),BigInteger.Parse("27126817151861700072792723") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184601Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184601.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184601Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184601.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184601.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184601Inst Instance=new A184601Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184602
{
public static readonly BigInteger[] Value={ 2880L,446426L,89538170L,19597196907L,4461217004146L,1038876920232926L,245608218357699105L,BigInteger.Parse("58705095126108291860"),BigInteger.Parse("14148602810460027001369"),BigInteger.Parse("3432240397744170829576350"),BigInteger.Parse("836984055384644047944565034") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184602Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184602.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184602Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184602.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184602.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184602Inst Instance=new A184602Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184603
{
public static readonly BigInteger[] Value={ 10704L,3333345L,1339793447L,586441134417L,266823559411796L,124201308194651058L,BigInteger.Parse("58705095126108291860"),BigInteger.Parse("28056029360014523631654"),BigInteger.Parse("13521010840482176059922831"),BigInteger.Parse("6558986191129563851102130327") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184603Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184603.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184603Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184603.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184603.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184603Inst Instance=new A184603Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184652
{
public static readonly long[] Value={ 212898L,11826498L,11826498L,657272274L,2393686398L,657272274L,36516002466L,484872198498L,484872198498L,36516002466L,2028771948738L,98159708768710L,358095672726522L,98159708768710L,2028771948738L,112716440618754L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184652Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184652.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184652Inst : IEnumerable<long>
{
public static readonly long[] Value=A184652.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184652.Bytes);
public long this[int i]=>Value[i];

public static A184652Inst Instance=new A184652Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184653
{
public static readonly long[] Value={ 3L,5L,7L,10L,12L,14L,17L,19L,21L,24L,26L,29L,31L,33L,36L,38L,40L,43L,45L,48L,50L,52L,55L,57L,59L,62L,64L,66L,69L,71L,74L,76L,78L,81L,83L,85L,88L,90L,92L,95L,97L,100L,102L,104L,107L,109L,111L,114L,116L,118L,121L,123L,126L,128L,130L,133L,135L,137L,140L,142L,145L,147L,149L,152L,154L,156L,159L,161L,163L,166L,168L,171L,173L,175L,178L,180L,182L,185L,187L,189L,192L,194L,197L,199L,201L,204L,206L,208L,211L,213L,215L,218L,220L,223L,225L,227L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184653Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184653.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184653Inst : IEnumerable<long>
{
public static readonly long[] Value=A184653.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184653.Bytes);
public long this[int i]=>Value[i];

public static A184653Inst Instance=new A184653Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184654
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,11L,13L,14L,16L,18L,20L,21L,23L,25L,27L,28L,30L,32L,33L,35L,37L,39L,40L,42L,44L,46L,47L,49L,51L,53L,54L,56L,58L,59L,61L,63L,65L,66L,68L,70L,72L,73L,75L,77L,79L,80L,82L,84L,85L,87L,89L,91L,92L,94L,96L,98L,99L,101L,103L,104L,106L,108L,110L,111L,113L,115L,117L,118L,120L,122L,124L,125L,127L,129L,130L,132L,134L,136L,137L,139L,141L,143L,144L,146L,148L,150L,151L,153L,155L,156L,158L,160L,162L,163L,165L,167L,169L,170L,172L,174L,176L,177L,179L,181L,182L,184L,186L,188L,189L,191L,193L,195L,196L,198L,200L,201L,203L,205L,207L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184654Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184654.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184654Inst : IEnumerable<long>
{
public static readonly long[] Value=A184654.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184654.Bytes);
public long this[int i]=>Value[i];

public static A184654Inst Instance=new A184654Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184655
{
public static readonly long[] Value={ 3L,5L,8L,10L,12L,15L,17L,19L,22L,24L,26L,29L,31L,34L,36L,38L,41L,43L,45L,48L,50L,52L,55L,57L,60L,62L,64L,67L,69L,71L,74L,76L,78L,81L,83L,86L,88L,90L,93L,95L,97L,100L,102L,105L,107L,109L,112L,114L,116L,119L,121L,123L,126L,128L,131L,133L,135L,138L,140L,142L,145L,147L,149L,152L,154L,157L,159L,161L,164L,166L,168L,171L,173L,175L,178L,180L,183L,185L,187L,190L,192L,194L,197L,199L,202L,204L,206L,209L,211L,213L,216L,218L,220L,223L,225L,228L,230L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184655Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184655.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184655Inst : IEnumerable<long>
{
public static readonly long[] Value=A184655.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184655.Bytes);
public long this[int i]=>Value[i];

public static A184655Inst Instance=new A184655Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184656
{
public static readonly long[] Value={ 1L,2L,4L,5L,7L,9L,10L,12L,14L,15L,17L,18L,20L,22L,23L,25L,27L,28L,30L,31L,33L,35L,36L,38L,39L,41L,43L,44L,46L,48L,49L,51L,52L,54L,56L,57L,59L,60L,62L,64L,65L,67L,69L,70L,72L,73L,75L,77L,78L,80L,82L,83L,85L,86L,88L,90L,91L,93L,94L,96L,98L,99L,101L,103L,104L,106L,107L,109L,111L,112L,114L,115L,117L,119L,120L,122L,124L,125L,127L,128L,130L,132L,133L,135L,137L,138L,140L,141L,143L,145L,146L,148L,149L,151L,153L,154L,156L,158L,159L,161L,162L,164L,166L,167L,169L,171L,172L,174L,175L,177L,179L,180L,182L,183L,185L,187L,188L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184656Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184656.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184656Inst : IEnumerable<long>
{
public static readonly long[] Value=A184656.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184656.Bytes);
public long this[int i]=>Value[i];

public static A184656Inst Instance=new A184656Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184657
{
public static readonly long[] Value={ 3L,6L,8L,11L,13L,16L,19L,21L,24L,26L,29L,32L,34L,37L,40L,42L,45L,47L,50L,53L,55L,58L,61L,63L,66L,68L,71L,74L,76L,79L,81L,84L,87L,89L,92L,95L,97L,100L,102L,105L,108L,110L,113L,116L,118L,121L,123L,126L,129L,131L,134L,136L,139L,142L,144L,147L,150L,152L,155L,157L,160L,163L,165L,168L,170L,173L,176L,178L,181L,184L,186L,189L,191L,194L,197L,199L,202L,205L,207L,210L,212L,215L,218L,220L,223L,225L,228L,231L,233L,236L,239L,241L,244L,246L,249L,252L,254L,257L,259L,262L,265L,267L,270L,273L,275L,278L,280L,283L,286L,288L,291L,294L,296L,299L,301L,304L,307L,309L,312L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184657Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184657.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184657Inst : IEnumerable<long>
{
public static readonly long[] Value=A184657.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184657.Bytes);
public long this[int i]=>Value[i];

public static A184657Inst Instance=new A184657Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184658
{
public static readonly long[] Value={ 1L,2L,4L,6L,7L,9L,10L,12L,14L,15L,17L,19L,20L,22L,23L,25L,27L,28L,30L,32L,33L,35L,36L,38L,40L,41L,43L,44L,46L,48L,49L,51L,53L,54L,56L,57L,59L,61L,62L,64L,66L,67L,69L,70L,72L,74L,75L,77L,78L,80L,82L,83L,85L,87L,88L,90L,91L,93L,95L,96L,98L,99L,101L,103L,104L,106L,108L,109L,111L,112L,114L,116L,117L,119L,121L,122L,124L,125L,127L,129L,130L,132L,133L,135L,137L,138L,140L,142L,143L,145L,146L,148L,150L,151L,153L,154L,156L,158L,159L,161L,163L,164L,166L,167L,169L,171L,172L,174L,176L,177L,179L,180L,182L,184L,185L,187L,188L,190L,192L,193L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184658Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184658.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184658Inst : IEnumerable<long>
{
public static readonly long[] Value=A184658.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184658.Bytes);
public long this[int i]=>Value[i];

public static A184658Inst Instance=new A184658Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184659
{
public static readonly long[] Value={ 3L,5L,8L,11L,13L,16L,18L,21L,24L,26L,29L,31L,34L,37L,39L,42L,45L,47L,50L,52L,55L,58L,60L,63L,65L,68L,71L,73L,76L,79L,81L,84L,86L,89L,92L,94L,97L,100L,102L,105L,107L,110L,113L,115L,118L,120L,123L,126L,128L,131L,134L,136L,139L,141L,144L,147L,149L,152L,155L,157L,160L,162L,165L,168L,170L,173L,175L,178L,181L,183L,186L,189L,191L,194L,196L,199L,202L,204L,207L,209L,212L,215L,217L,220L,223L,225L,228L,230L,233L,236L,238L,241L,244L,246L,249L,251L,254L,257L,259L,262L,264L,267L,270L,272L,275L,278L,280L,283L,285L,288L,291L,293L,296L,298L,301L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184659Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184659.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184659Inst : IEnumerable<long>
{
public static readonly long[] Value=A184659.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184659.Bytes);
public long this[int i]=>Value[i];

public static A184659Inst Instance=new A184659Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184660
{
public static readonly BigInteger[] Value={ 49246L,1352770L,35802874L,742295518L,17984702194L,426536161750L,9789497534962L,230620412950366L,5400694882775818L,125973364404722134L,2950593093864039562L,BigInteger.Parse("69018872882507417134"),BigInteger.Parse("1613797015382550341674"),BigInteger.Parse("37757644419274785266902") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184660Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184660.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184660Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184660.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184660.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184660Inst Instance=new A184660Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184661
{
public static readonly BigInteger[] Value={ 1352770L,119805310L,10047874534L,564143008386L,42151760266070L,3068818942252922L,213876509386388262L,15511761707358612866UL,BigInteger.Parse("1118945141084512520558"),BigInteger.Parse("80408360347124360370778") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184661Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184661.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184661Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184661.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184661.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184661Inst Instance=new A184661Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184662
{
public static readonly long[] Value={ 35802874L,10047874534L,2738040689182L,452748537865658L,113762289821953494L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184662Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184662.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184662Inst : IEnumerable<long>
{
public static readonly long[] Value=A184662.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184662.Bytes);
public long this[int i]=>Value[i];

public static A184662Inst Instance=new A184662Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184663
{
public static readonly long[] Value={ 49246L,1352770L,1352770L,35802874L,119805310L,35802874L,742295518L,10047874534L,10047874534L,742295518L,17984702194L,564143008386L,2738040689182L,564143008386L,17984702194L,426536161750L,42151760266070L,452748537865658L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184663Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184663.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184663Inst : IEnumerable<long>
{
public static readonly long[] Value=A184663.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184663.Bytes);
public long this[int i]=>Value[i];

public static A184663Inst Instance=new A184663Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184664
{
public static readonly BigInteger[] Value={ 150L,67330L,266060160L,11348244616180L,4705518067315949795L,BigInteger.Parse("19869188673828370548366580"),BigInteger.Parse("837185450907978354702239657652981") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184664Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184664.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184664Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184664.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184664.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184664Inst Instance=new A184664Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184665
{
public static readonly long[] Value={ 150L,1740L,19269L,216912L,2430631L,27278035L,305991368L,3432961182L,38513146024L,432071200891L,4847297854288L,54380688812185L,610083824961241L,6844384156411424L,76785501492801006L,861438105302681684L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184665Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184665.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184665Inst : IEnumerable<long>
{
public static readonly long[] Value=A184665.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184665.Bytes);
public long this[int i]=>Value[i];

public static A184665Inst Instance=new A184665Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184666
{
public static readonly BigInteger[] Value={ 1740L,67330L,2405797L,88458672L,3225439429L,117938741095L,4308670152724L,157454260497016L,5753418267657560L,210237556594325891L,7682287249431007868L,BigInteger.Parse("280719194120503850605"),BigInteger.Parse("10257776899125672523995"),BigInteger.Parse("374830158857789457998588") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184666Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184666.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184666Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184666.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184666.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184666Inst Instance=new A184666Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184667
{
public static readonly BigInteger[] Value={ 19269L,2405797L,266060160L,30765364899L,3509487618613L,402221585928132L,46028365937520330L,5269979734803579913L,BigInteger.Parse("603279614829234560146"),BigInteger.Parse("69064202595023175071177"),BigInteger.Parse("7906407074804511304606829") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184667Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184667.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184667Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184667.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184667.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184667Inst Instance=new A184667Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184716
{
public static readonly long[] Value={ 1L,1L,2L,3L,6L,39L,209L,947L,4403L,20825L,95461L,420312L,1824610L,7767715L,32447127L,133426790L,540454735L,2157136063L,8491433827L,32994222337L,126618582468L,480170037501L,1800457116471L,6678324836291L,24515228772443L,89097534819082L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184716Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184716.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184716Inst : IEnumerable<long>
{
public static readonly long[] Value=A184716.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184716.Bytes);
public long this[int i]=>Value[i];

public static A184716Inst Instance=new A184716Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184717
{
public static readonly long[] Value={ 1L,1L,2L,2L,20L,65L,356L,1958L,11206L,61215L,322965L,1666746L,8471382L,42144511L,206062493L,990942629L,4690125830L,21869723804L,100547402432L,456094690719L,2042617816297L,9036778212037L,39515366452359L,170866409817131L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184717Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184717.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184717Inst : IEnumerable<long>
{
public static readonly long[] Value=A184717.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184717.Bytes);
public long this[int i]=>Value[i];

public static A184717Inst Instance=new A184717Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184718
{
public static readonly long[] Value={ 1L,1L,2L,2L,15L,76L,560L,3604L,24327L,152952L,925232L,5495907L,31966719L,182331659L,1021217701L,5622236708L,30456148470L,162478306805L,854327762047L,4430787907798L,22680031606293L,114649453836280L,572666511225162L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184718Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184718.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184718Inst : IEnumerable<long>
{
public static readonly long[] Value=A184718.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184718.Bytes);
public long this[int i]=>Value[i];

public static A184718Inst Instance=new A184718Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184719
{
public static readonly long[] Value={ 1L,1L,2L,3L,18L,114L,929L,6939L,49405L,343061L,2349749L,15744977L,103294333L,664143853L,4191000242L,25991406059L,158554966581L,952308975542L,5636023020692L,32891357753442L,189405665405678L,1076880550812387L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184719Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184719.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184719Inst : IEnumerable<long>
{
public static readonly long[] Value=A184719.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184719.Bytes);
public long this[int i]=>Value[i];

public static A184719Inst Instance=new A184719Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184720
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,2L,1L,1L,2L,2L,1L,1L,2L,2L,3L,1L,1L,2L,2L,5L,4L,1L,1L,2L,2L,7L,9L,5L,1L,1L,2L,3L,6L,19L,22L,6L,1L,1L,2L,2L,6L,22L,39L,47L,8L,1L,1L,2L,2L,20L,39L,125L,120L,95L,10L,1L,1L,2L,3L,15L,65L,209L,467L,411L,197L,12L,1L,1L,2L,3L,18L,76L,356L,947L,1669L,1310L,394L,15L,1L,1L,2L,4L,29L,114L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184720Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184720.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184720Inst : IEnumerable<long>
{
public static readonly long[] Value=A184720.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184720.Bytes);
public long this[int i]=>Value[i];

public static A184720Inst Instance=new A184720Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184721
{
public static readonly long[] Value={ 2L,2L,2L,2L,3L,2L,2L,3L,3L,4L,4L,5L,4L,4L,6L,5L,6L,3L,5L,4L,6L,6L,2L,7L,7L,5L,6L,5L,7L,8L,6L,7L,15L,10L,6L,8L,7L,9L,9L,8L,9L,10L,9L,9L,13L,4L,8L,14L,8L,14L,10L,6L,5L,11L,11L,12L,12L,13L,16L,16L,14L,11L,16L,8L,9L,22L,13L,14L,14L,15L,8L,17L,17L,11L,20L,20L,15L,20L,15L,15L,17L,16L,12L,21L,11L,11L,18L,16L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184721Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184721.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184721Inst : IEnumerable<long>
{
public static readonly long[] Value=A184721.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184721.Bytes);
public long this[int i]=>Value[i];

public static A184721Inst Instance=new A184721Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184722
{
public static readonly long[] Value={ 3L,5L,7L,6L,6L,20L,15L,18L,29L,20L,22L,41L,33L,49L,43L,51L,47L,71L,70L,77L,96L,77L,84L,121L,112L,121L,152L,162L,130L,162L,159L,177L,184L,184L,212L,219L,214L,216L,251L,255L,286L,329L,279L,304L,339L,317L,322L,371L,359L,373L,385L,429L,435L,502L,495L,499L,528L,500L,546L,551L,578L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184722Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184722.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184722Inst : IEnumerable<long>
{
public static readonly long[] Value=A184722.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184722.Bytes);
public long this[int i]=>Value[i];

public static A184722Inst Instance=new A184722Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184723
{
public static readonly long[] Value={ 4L,9L,19L,22L,39L,65L,76L,114L,170L,192L,253L,315L,430L,488L,568L,678L,786L,988L,1176L,1284L,1476L,1732L,1948L,2178L,2465L,2753L,2892L,3339L,3691L,3989L,4422L,4817L,5310L,5740L,6312L,6881L,7393L,7830L,8759L,9214L,9887L,10657L,11192L,12196L,12944L,13633L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184723Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184723.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184723Inst : IEnumerable<long>
{
public static readonly long[] Value=A184723.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184723.Bytes);
public long this[int i]=>Value[i];

public static A184723Inst Instance=new A184723Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184724
{
public static readonly long[] Value={ 5L,22L,39L,125L,209L,356L,560L,929L,1348L,2003L,2791L,3848L,4842L,6474L,8186L,10319L,13169L,16049L,19588L,24134L,28755L,34513L,40850L,47285L,55523L,63884L,73472L,85289L,97062L,110655L,124751L,140892L,157697L,178616L,197986L,221249L,245802L,272785L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184724Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184724.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184724Inst : IEnumerable<long>
{
public static readonly long[] Value=A184724.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184724.Bytes);
public long this[int i]=>Value[i];

public static A184724Inst Instance=new A184724Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184725
{
public static readonly long[] Value={ 6L,47L,120L,467L,947L,1958L,3604L,6939L,11333L,18282L,27796L,40692L,57628L,81302L,111670L,150145L,198248L,259843L,333599L,426333L,531093L,668121L,818444L,1003797L,1214530L,1464395L,1753048L,2090590L,2464415L,2907699L,3396888L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184725Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184725.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184725Inst : IEnumerable<long>
{
public static readonly long[] Value=A184725.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184725.Bytes);
public long this[int i]=>Value[i];

public static A184725Inst Instance=new A184725Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184726
{
public static readonly long[] Value={ 0L,0L,1L,1L,1L,3L,1L,1L,5L,1L,1L,7L,1L,5L,9L,1L,1L,11L,7L,1L,13L,1L,1L,15L,1L,7L,17L,1L,11L,19L,1L,1L,21L,13L,1L,23L,1L,1L,25L,11L,1L,27L,1L,17L,29L,1L,13L,31L,19L,1L,33L,1L,1L,35L,1L,1L,37L,1L,23L,39L,17L,11L,41L,25L,1L,43L,1L,19L,45L,1L,1L,47L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184726Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184726.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184726Inst : IEnumerable<long>
{
public static readonly long[] Value=A184726.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184726.Bytes);
public long this[int i]=>Value[i];

public static A184726Inst Instance=new A184726Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184727
{
public static readonly long[] Value={ 0L,0L,1L,2L,2L,2L,4L,2L,4L,6L,5L,2L,8L,2L,7L,10L,8L,2L,12L,2L,10L,14L,11L,2L,16L,10L,13L,18L,14L,2L,20L,2L,16L,22L,17L,14L,24L,2L,19L,26L,20L,2L,28L,2L,22L,30L,23L,2L,32L,14L,25L,34L,26L,2L,36L,22L,28L,38L,29L,2L,40L,2L,31L,42L,32L,26L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184727Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184727.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184727Inst : IEnumerable<long>
{
public static readonly long[] Value=A184727.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184727.Bytes);
public long this[int i]=>Value[i];

public static A184727Inst Instance=new A184727Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184728
{
public static readonly long[] Value={ 0L,0L,8L,6L,13L,9L,20L,19L,24L,19L,32L,33L,32L,37L,32L,43L,47L,47L,53L,56L,54L,59L,61L,64L,71L,72L,79L,84L,85L,83L,89L,92L,93L,84L,101L,107L,112L,117L,117L,120L,121L,117L,125L,132L,127L,140L,141L,141L,144L,137L,152L,157L,157L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184728Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184728.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184728Inst : IEnumerable<long>
{
public static readonly long[] Value=A184728.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184728.Bytes);
public long this[int i]=>Value[i];

public static A184728Inst Instance=new A184728Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184729
{
public static readonly long[] Value={ 0L,0L,4L,1L,1L,1L,10L,1L,12L,1L,16L,11L,8L,1L,4L,1L,1L,1L,1L,28L,9L,1L,1L,8L,1L,12L,1L,42L,17L,1L,1L,46L,31L,7L,1L,1L,28L,39L,39L,60L,11L,13L,25L,66L,1L,70L,47L,47L,72L,1L,38L,1L,1L,26L,1L,7L,88L,1L,1L,61L,20L,17L,100L,67L,67L,102L,29L,41L,106L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184729Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184729.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184729Inst : IEnumerable<long>
{
public static readonly long[] Value=A184729.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184729.Bytes);
public long this[int i]=>Value[i];

public static A184729Inst Instance=new A184729Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184730
{
public static readonly BigInteger[] Value={ 1L,2L,5L,20L,159L,3152L,168036L,20428850L,5796209814L,4052041564524L,6210335115944263L,BigInteger.Parse("21470958882165989854"),BigInteger.Parse("183818137919395949397148"),BigInteger.Parse("3517964195874870876682733562"),BigInteger.Parse("147909303669340763210833833705995") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184730Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184730.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184730Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184730.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184730.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184730Inst Instance=new A184730Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184731
{
public static readonly BigInteger[] Value={ 1L,2L,6L,38L,490L,14152L,969444L,140621476L,46041241698L,36363843928316L,62022250535177416L,BigInteger.Parse("236043875222171125276"),BigInteger.Parse("2205302277098968939256248"),BigInteger.Parse("45728754995013679582534494332"),BigInteger.Parse("2070631745797418828103776968679204") };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(e=>e.ToByteArray());
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184731Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184731.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184731Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A184731.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
for (var i=0; i < Value.Length; i++)
{
var b=Value[i].ToByteArray();
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184731.Bytes);
public BigInteger this[int i]=>Value[i];

public static A184731Inst Instance=new A184731Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184796
{
public static readonly long[] Value={ 3L,5L,13L,17L,19L,29L,31L,41L,43L,53L,67L,71L,79L,83L,103L,107L,109L,131L,157L,173L,181L,193L,197L,199L,211L,223L,233L,239L,251L,263L,271L,277L,311L,313L,337L,349L,353L,367L,379L,389L,401L,419L,431L,433L,439L,443L,457L,467L,479L,491L,509L,521L,523L,547L,557L,569L,571L,587L,599L,601L,607L,613L,647L,659L,661L,673L,677L,691L,701L,727L,739L,743L,751L,769L,827L,829L,853L,857L,859L,881L,883L,907L,911L,919L,937L,947L,971L,983L,997L,1009L,1013L,1021L,1039L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184796Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184796.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184796Inst : IEnumerable<long>
{
public static readonly long[] Value=A184796.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184796.Bytes);
public long this[int i]=>Value[i];

public static A184796Inst Instance=new A184796Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184797
{
public static readonly long[] Value={ 2L,3L,8L,10L,11L,17L,18L,24L,25L,31L,39L,41L,46L,48L,60L,62L,63L,76L,91L,100L,105L,112L,114L,115L,122L,129L,135L,138L,145L,152L,157L,160L,180L,181L,195L,202L,204L,212L,219L,225L,232L,242L,249L,250L,254L,256L,264L,270L,277L,284L,294L,301L,302L,316L,322L,329L,330L,339L,346L,347L,351L,354L,374L,381L,382L,389L,391L,399L,405L,420L,427L,429L,434L,444L,478L,479L,493L,495L,496L,509L,510L,524L,526L,531L,541L,547L,561L,568L,576L,583L,585L,590L,600L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184797Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184797.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184797Inst : IEnumerable<long>
{
public static readonly long[] Value=A184797.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184797.Bytes);
public long this[int i]=>Value[i];

public static A184797Inst Instance=new A184797Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184798
{
public static readonly long[] Value={ 2L,3L,6L,7L,8L,10L,11L,13L,14L,16L,19L,20L,22L,23L,27L,28L,29L,32L,37L,40L,42L,44L,45L,46L,47L,48L,51L,52L,54L,56L,58L,59L,64L,65L,68L,70L,71L,73L,75L,77L,79L,81L,83L,84L,85L,86L,88L,91L,92L,94L,97L,98L,99L,101L,102L,104L,105L,107L,109L,110L,111L,112L,118L,120L,121L,122L,123L,125L,126L,129L,131L,132L,133L,136L,144L,145L,147L,148L,149L,152L,153L,155L,156L,157L,159L,161L,164L,166L,168L,169L,170L,172L,175L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184798Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184798.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184798Inst : IEnumerable<long>
{
public static readonly long[] Value=A184798.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184798.Bytes);
public long this[int i]=>Value[i];

public static A184798Inst Instance=new A184798Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184799
{
public static readonly long[] Value={ 2L,7L,11L,23L,37L,47L,59L,61L,73L,89L,97L,101L,113L,127L,137L,139L,149L,151L,163L,167L,179L,191L,227L,229L,241L,257L,269L,281L,283L,293L,307L,317L,331L,347L,359L,373L,383L,397L,409L,421L,449L,461L,463L,487L,499L,503L,541L,563L,577L,593L,617L,619L,631L,641L,643L,653L,683L,709L,719L,733L,757L,761L,773L,787L,797L,809L,811L,821L,823L,839L,863L,877L,887L,929L,941L,953L,967L,977L,991L,1019L,1031L,1033L,1069L,1093L,1097L,1109L,1123L,1171L,1187L,1201L,1213L,1223L,1237L,1249L,1277L,1289L,1291L,1301L,1303L,1327L,1367L,1381L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184799Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184799.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184799Inst : IEnumerable<long>
{
public static readonly long[] Value=A184799.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184799.Bytes);
public long this[int i]=>Value[i];

public static A184799Inst Instance=new A184799Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184800
{
public static readonly long[] Value={ 1L,3L,5L,10L,16L,20L,25L,26L,31L,38L,41L,43L,48L,54L,58L,59L,63L,64L,69L,71L,76L,81L,96L,97L,102L,109L,114L,119L,120L,124L,130L,134L,140L,147L,152L,158L,162L,168L,173L,178L,190L,195L,196L,206L,211L,213L,229L,238L,244L,251L,261L,262L,267L,271L,272L,276L,289L,300L,304L,310L,320L,322L,327L,333L,337L,342L,343L,347L,348L,355L,365L,371L,375L,393L,398L,403L,409L,413L,419L,431L,436L,437L,452L,462L,464L,469L,475L,495L,502L,508L,513L,517L,523L,528L,540L,545L,546L,550L,551L,561L,578L,584L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184800Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184800.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184800Inst : IEnumerable<long>
{
public static readonly long[] Value=A184800.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184800.Bytes);
public long this[int i]=>Value[i];

public static A184800Inst Instance=new A184800Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184801
{
public static readonly long[] Value={ 1L,4L,5L,9L,12L,15L,17L,18L,21L,24L,25L,26L,30L,31L,33L,34L,35L,36L,38L,39L,41L,43L,49L,50L,53L,55L,57L,60L,61L,62L,63L,66L,67L,69L,72L,74L,76L,78L,80L,82L,87L,89L,90L,93L,95L,96L,100L,103L,106L,108L,113L,114L,115L,116L,117L,119L,124L,127L,128L,130L,134L,135L,137L,138L,139L,140L,141L,142L,143L,146L,150L,151L,154L,158L,160L,162L,163L,165L,167L,171L,173L,174L,180L,183L,184L,186L,188L,193L,195L,197L,198L,200L,203L,204L,206L,209L,210L,212L,213L,217L,219L,221L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184801Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184801.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184801Inst : IEnumerable<long>
{
public static readonly long[] Value=A184801.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184801.Bytes);
public long this[int i]=>Value[i];

public static A184801Inst Instance=new A184801Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184802
{
public static readonly long[] Value={ 2L,11L,13L,17L,29L,31L,53L,67L,71L,73L,89L,107L,109L,127L,131L,149L,163L,167L,181L,199L,223L,239L,241L,257L,263L,277L,281L,283L,313L,317L,337L,353L,373L,389L,409L,431L,433L,449L,467L,487L,491L,503L,509L,521L,523L,541L,547L,563L,599L,601L,617L,619L,641L,643L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184802Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184802.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184802Inst : IEnumerable<long>
{
public static readonly long[] Value=A184802.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184802.Bytes);
public long this[int i]=>Value[i];

public static A184802Inst Instance=new A184802Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184803
{
public static readonly long[] Value={ 1L,5L,6L,8L,13L,14L,24L,30L,32L,33L,40L,48L,49L,57L,59L,67L,73L,75L,81L,89L,100L,107L,108L,115L,118L,124L,126L,127L,140L,142L,151L,158L,167L,174L,183L,193L,194L,201L,209L,218L,220L,225L,228L,233L,234L,242L,245L,252L,268L,269L,276L,277L,287L,288L,295L,296L,301L,303L,328L,336L,344L,346L,352L,362L,363L,370L,371L,386L,394L,395L,397L,406L,411L,421L,437L,440L,446L,456L,457L,462L,465L,488L,489L,491L,496L,505L,515L,516L,524L,531L,547L,550L,559L,572L,574L,582L,583L,590L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184803Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184803.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184803Inst : IEnumerable<long>
{
public static readonly long[] Value=A184803.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184803.Bytes);
public long this[int i]=>Value[i];

public static A184803Inst Instance=new A184803Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184804
{
public static readonly long[] Value={ 1L,5L,6L,7L,10L,11L,16L,19L,20L,21L,24L,28L,29L,31L,32L,35L,38L,39L,42L,46L,48L,52L,53L,55L,56L,59L,60L,61L,65L,66L,68L,71L,74L,77L,80L,83L,84L,87L,91L,93L,94L,96L,97L,98L,99L,100L,101L,103L,109L,110L,113L,114L,116L,117L,120L,121L,122L,123L,130L,133L,136L,137L,138L,140L,141L,144L,145L,150L,152L,153L,154L,155L,157L,160L,165L,166L,168L,171L,172L,174L,175L,182L,183L,184L,186L,189L,190L,191L,193L,195L,200L,201L,204L,207L,208L,212L,213L,215L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184804Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184804.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184804Inst : IEnumerable<long>
{
public static readonly long[] Value=A184804.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184804.Bytes);
public long this[int i]=>Value[i];

public static A184804Inst Instance=new A184804Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184805
{
public static readonly long[] Value={ 3L,5L,7L,19L,23L,37L,41L,43L,47L,59L,61L,79L,83L,97L,101L,103L,113L,137L,139L,151L,157L,173L,179L,191L,193L,197L,211L,227L,229L,233L,251L,269L,271L,293L,307L,311L,331L,347L,349L,359L,367L,379L,383L,397L,401L,419L,421L,439L,443L,457L,461L,463L,479L,499L,557L,569L,571L,577L,587L,593L,607L,613L,631L,647L,653L,683L,691L,701L,709L,719L,727L,739L,743L,757L,761L,797L,821L,823L,839L,853L,857L,859L,877L,911L,929L,937L,947L,953L,967L,971L,991L,1009L,1013L,1031L,1049L,1051L,1061L,1063L,1069L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184805Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184805.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184805Inst : IEnumerable<long>
{
public static readonly long[] Value=A184805.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184805.Bytes);
public long this[int i]=>Value[i];

public static A184805Inst Instance=new A184805Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184806
{
public static readonly long[] Value={ 2L,3L,4L,11L,13L,21L,23L,24L,26L,33L,34L,44L,46L,54L,56L,57L,63L,76L,77L,84L,87L,96L,99L,106L,107L,109L,117L,126L,127L,129L,139L,149L,150L,162L,170L,172L,183L,192L,193L,199L,203L,210L,212L,220L,222L,232L,233L,243L,245L,253L,255L,256L,265L,276L,308L,315L,316L,319L,325L,328L,336L,339L,349L,358L,361L,378L,382L,388L,392L,398L,402L,409L,411L,419L,421L,441L,454L,455L,464L,472L,474L,475L,485L,504L,514L,518L,524L,527L,535L,537L,548L,558L,560L,570L,580L,581L,587L,588L,591L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184806Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184806.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184806Inst : IEnumerable<long>
{
public static readonly long[] Value=A184806.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184806.Bytes);
public long this[int i]=>Value[i];

public static A184806Inst Instance=new A184806Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184807
{
public static readonly long[] Value={ 2L,3L,4L,8L,9L,12L,13L,14L,15L,17L,18L,22L,23L,25L,26L,27L,30L,33L,34L,36L,37L,40L,41L,43L,44L,45L,47L,49L,50L,51L,54L,57L,58L,62L,63L,64L,67L,69L,70L,72L,73L,75L,76L,78L,79L,81L,82L,85L,86L,88L,89L,90L,92L,95L,102L,104L,105L,106L,107L,108L,111L,112L,115L,118L,119L,124L,125L,126L,127L,128L,129L,131L,132L,134L,135L,139L,142L,143L,146L,147L,148L,149L,151L,156L,158L,159L,161L,162L,163L,164L,167L,169L,170L,173L,176L,177L,178L,179L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184807Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184807.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184807Inst : IEnumerable<long>
{
public static readonly long[] Value=A184807.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184807.Bytes);
public long this[int i]=>Value[i];

public static A184807Inst Instance=new A184807Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184808
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,10L,12L,14L,16L,18L,19L,21L,23L,25L,27L,29L,30L,32L,34L,36L,38L,39L,41L,43L,45L,47L,49L,50L,52L,54L,56L,58L,59L,61L,63L,65L,67L,69L,70L,72L,74L,76L,78L,79L,81L,83L,85L,87L,89L,90L,92L,94L,96L,98L,99L,101L,103L,105L,107L,108L,110L,112L,114L,116L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184808Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184808.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184808Inst : IEnumerable<long>
{
public static readonly long[] Value=A184808.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184808.Bytes);
public long this[int i]=>Value[i];

public static A184808Inst Instance=new A184808Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184809
{
public static readonly long[] Value={ 2L,4L,6L,8L,11L,13L,15L,17L,20L,22L,24L,26L,28L,31L,33L,35L,37L,40L,42L,44L,46L,48L,51L,53L,55L,57L,60L,62L,64L,66L,68L,71L,73L,75L,77L,80L,82L,84L,86L,88L,91L,93L,95L,97L,100L,102L,104L,106L,109L,111L,113L,115L,117L,120L,122L,124L,126L,129L,131L,133L,135L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184809Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184809.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184809Inst : IEnumerable<long>
{
public static readonly long[] Value=A184809.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184809.Bytes);
public long this[int i]=>Value[i];

public static A184809Inst Instance=new A184809Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184810
{
public static readonly long[] Value={ 2L,3L,4L,8L,9L,10L,13L,14L,15L,17L,18L,19L,22L,23L,24L,26L,27L,28L,31L,34L,38L,39L,41L,42L,45L,46L,48L,49L,52L,53L,55L,56L,59L,60L,61L,66L,68L,72L,75L,76L,78L,79L,81L,82L,85L,86L,88L,89L,90L,92L,95L,96L,98L,99L,100L,102L,103L,106L,108L,109L,110L,112L,113L,114L,116L,117L,119L,120L,121L,122L,123L,124L,126L,128L,130L,131L,134L,135L,137L,139L,141L,142L,146L,147L,148L,149L,151L,152L,156L,157L,159L,162L,164L,165L,167L,168L,169L,170L,171L,173L,174L,175L,176L,177L,180L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184810Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184810.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184810Inst : IEnumerable<long>
{
public static readonly long[] Value=A184810.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184810.Bytes);
public long this[int i]=>Value[i];

public static A184810Inst Instance=new A184810Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184811
{
public static readonly long[] Value={ 1L,5L,6L,7L,11L,12L,16L,20L,21L,25L,29L,30L,32L,33L,35L,36L,37L,40L,43L,44L,47L,50L,51L,54L,57L,58L,62L,63L,64L,65L,67L,69L,70L,71L,73L,74L,77L,80L,83L,84L,87L,91L,93L,94L,97L,101L,104L,105L,107L,111L,115L,118L,125L,127L,129L,132L,133L,136L,138L,140L,143L,144L,145L,150L,153L,154L,155L,158L,160L,161L,163L,166L,172L,178L,179L,181L,185L,188L,192L,194L,197L,200L,205L,206L,207L,208L,211L,212L,213L,215L,216L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184811Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184811.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184811Inst : IEnumerable<long>
{
public static readonly long[] Value=A184811.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184811.Bytes);
public long this[int i]=>Value[i];

public static A184811Inst Instance=new A184811Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184908
{
public static readonly long[] Value={ 1L,7L,5L,0L,7L,5L,0L,7L,10L,0L,6L,3L,0L,5L,9L,0L,7L,7L,0L,7L,9L,0L,5L,6L,0L,6L,7L,0L,10L,7L,0L,4L,5L,0L,11L,7L,0L,10L,9L,0L,9L,4L,0L,4L,8L,0L,2L,6L,0L,9L,5L,0L,10L,9L,0L,8L,6L,0L,4L,3L,0L,4L,11L,0L,9L,3L,0L,5L,8L,0L,6L,3L,0L,11L,7L,0L,6L,8L,0L,5L,6L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184908Inst : IEnumerable<long>
{
public static readonly long[] Value=A184908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184908.Bytes);
public long this[int i]=>Value[i];

public static A184908Inst Instance=new A184908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184909
{
public static readonly long[] Value={ 3L,6L,9L,13L,16L,19L,24L,27L,30L,34L,37L,40L,44L,48L,51L,55L,58L,61L,65L,68L,72L,76L,79L,82L,85L,89L,93L,96L,100L,103L,106L,110L,113L,117L,121L,124L,127L,131L,134L,137L,142L,145L,148L,152L,155L,158L,162L,166L,169L,172L,176L,179L,182L,187L,190L,193L,197L,200L,203L,207L,211L,214L,218L,221L,224L,228L,231L,235L,239L,242L,245L,249L,252L,256L,259L,263L,266L,269L,273L,276L,280L,284L,287L,290L,294L,297L,300L,305L,308L,311L,315L,318L,321L,325L,329L,332L,335L,339L,342L,345L,350L,353L,356L,360L,363L,366L,370L,374L,377L,381L,384L,387L,391L,394L,398L,402L,405L,408L,412L,415L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184909Inst : IEnumerable<long>
{
public static readonly long[] Value=A184909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184909.Bytes);
public long this[int i]=>Value[i];

public static A184909Inst Instance=new A184909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184910
{
public static readonly long[] Value={ 2L,5L,8L,11L,14L,17L,21L,23L,26L,29L,32L,35L,38L,42L,45L,47L,50L,53L,56L,59L,63L,66L,69L,71L,74L,77L,81L,84L,87L,90L,92L,95L,98L,102L,105L,108L,111L,114L,116L,119L,123L,126L,129L,132L,135L,138L,140L,144L,147L,150L,153L,156L,159L,163L,165L,168L,171L,174L,177L,180L,184L,186L,189L,192L,195L,198L,201L,205L,208L,210L,213L,216L,219L,223L,226L,229L,232L,234L,237L,240L,244L,247L,250L,253L,255L,258L,261L,265L,268L,271L,274L,277L,279L,282L,286L,289L,292L,295L,298L,301L,304L,307L,310L,313L,316L,319L,322L,326L,328L,331L,334L,337L,340L,343L,347L,349L,352L,355L,358L,361L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184910Inst : IEnumerable<long>
{
public static readonly long[] Value=A184910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184910.Bytes);
public long this[int i]=>Value[i];

public static A184910Inst Instance=new A184910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184911
{
public static readonly long[] Value={ 1L,4L,7L,10L,12L,15L,18L,20L,22L,25L,28L,31L,33L,36L,39L,41L,43L,46L,49L,52L,54L,57L,60L,62L,64L,67L,70L,73L,75L,78L,80L,83L,86L,88L,91L,94L,97L,99L,101L,104L,107L,109L,112L,115L,118L,120L,122L,125L,128L,130L,133L,136L,139L,141L,143L,146L,149L,151L,154L,157L,160L,161L,164L,167L,170L,173L,175L,178L,181L,183L,185L,188L,191L,194L,196L,199L,202L,204L,206L,209L,212L,215L,217L,220L,222L,225L,227L,230L,233L,236L,238L,241L,243L,246L,248L,251L,254L,257L,260L,262L,264L,267L,270L,272L,275L,278L,281L,283L,285L,288L,291L,293L,296L,299L,302L,303L,306L,309L,312L,314L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184911Inst : IEnumerable<long>
{
public static readonly long[] Value=A184911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184911.Bytes);
public long this[int i]=>Value[i];

public static A184911Inst Instance=new A184911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184912
{
public static readonly long[] Value={ 4L,9L,13L,19L,23L,28L,34L,39L,43L,49L,53L,58L,63L,69L,73L,79L,83L,88L,93L,98L,103L,109L,113L,118L,122L,128L,133L,138L,143L,148L,152L,158L,163L,168L,174L,178L,183L,188L,193L,197L,204L,208L,213L,218L,223L,227L,233L,238L,243L,247L,253L,257L,262L,268L,273L,277L,283L,287L,292L,297L,303L,307L,313L,318L,322L,328L,332L,338L,343L,348L,352L,358L,362L,368L,372L,378L,382L,387L,392L,397L,402L,408L,412L,417L,422L,427L,431L,438L,442L,447L,452L,457L,461L,467L,472L,477L,482L,487L,492L,496L,503L,507L,512L,517L,522L,526L,532L,537L,542L,547L,552L,556L,562L,566L,572L,577L,582L,586L,592L,596L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184912Inst : IEnumerable<long>
{
public static readonly long[] Value=A184912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184912.Bytes);
public long this[int i]=>Value[i];

public static A184912Inst Instance=new A184912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184913
{
public static readonly long[] Value={ 3L,7L,11L,16L,20L,24L,30L,33L,37L,42L,46L,50L,55L,60L,64L,68L,72L,76L,81L,85L,90L,95L,99L,102L,106L,111L,116L,120L,125L,129L,132L,137L,141L,146L,151L,155L,159L,164L,167L,171L,177L,181L,185L,190L,194L,198L,202L,207L,211L,215L,220L,224L,228L,234L,237L,241L,246L,250L,254L,259L,264L,267L,272L,276L,280L,285L,289L,294L,299L,302L,306L,311L,315L,320L,324L,329L,333L,336L,341L,345L,350L,355L,359L,363L,367L,371L,375L,381L,385L,389L,394L,398L,401L,406L,411L,415L,419L,424L,428L,432L,437L,441L,445L,450L,454L,458L,463L,468L,471L,476L,480L,484L,489L,493L,498L,502L,506L,510L,515L,519L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184913Inst : IEnumerable<long>
{
public static readonly long[] Value=A184913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184913.Bytes);
public long this[int i]=>Value[i];

public static A184913Inst Instance=new A184913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184914
{
public static readonly long[] Value={ 2L,6L,10L,14L,17L,21L,26L,29L,32L,36L,40L,44L,47L,52L,56L,59L,62L,66L,70L,74L,78L,82L,86L,89L,92L,96L,101L,105L,108L,112L,115L,119L,123L,127L,131L,135L,139L,142L,145L,149L,154L,157L,161L,165L,169L,172L,175L,180L,184L,187L,191L,195L,199L,203L,206L,210L,214L,217L,221L,225L,230L,232L,236L,240L,244L,248L,251L,256L,260L,263L,266L,270L,274L,279L,282L,286L,290L,293L,296L,300L,305L,309L,312L,316L,319L,323L,326L,331L,335L,339L,342L,346L,349L,353L,357L,361L,365L,369L,373L,376L,380L,384L,388L,391L,395L,399L,403L,407L,410L,414L,418L,421L,425L,429L,434L,436L,440L,444L,448L,451L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184914Inst : IEnumerable<long>
{
public static readonly long[] Value=A184914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184914.Bytes);
public long this[int i]=>Value[i];

public static A184914Inst Instance=new A184914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184915
{
public static readonly long[] Value={ 1L,5L,8L,12L,15L,18L,22L,25L,27L,31L,35L,38L,41L,45L,48L,51L,54L,57L,61L,65L,67L,71L,75L,77L,80L,84L,87L,91L,94L,97L,100L,104L,107L,110L,114L,117L,121L,124L,126L,130L,134L,136L,140L,144L,147L,150L,153L,156L,160L,162L,166L,170L,173L,176L,179L,182L,186L,189L,192L,196L,200L,201L,205L,209L,212L,216L,219L,222L,226L,229L,231L,235L,239L,242L,245L,249L,252L,255L,258L,261L,265L,269L,271L,275L,278L,281L,284L,288L,291L,295L,298L,301L,304L,308L,310L,314L,317L,321L,325L,327L,330L,334L,337L,340L,344L,347L,351L,354L,356L,360L,364L,366L,370L,374L,377L,379L,383L,386L,390L,393L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184915Inst : IEnumerable<long>
{
public static readonly long[] Value=A184915.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184915.Bytes);
public long this[int i]=>Value[i];

public static A184915Inst Instance=new A184915Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184916
{
public static readonly long[] Value={ 4L,9L,15L,19L,25L,31L,35L,41L,46L,51L,57L,62L,67L,72L,78L,83L,89L,94L,98L,104L,109L,115L,120L,125L,131L,135L,142L,147L,152L,157L,162L,168L,173L,179L,183L,188L,195L,199L,205L,210L,214L,220L,226L,231L,236L,242L,247L,252L,258L,263L,268L,273L,279L,284L,289L,295L,299L,305L,311L,315L,321L,326L,331L,337L,342L,347L,352L,358L,364L,368L,374L,379L,384L,390L,396L,400L,405L,411L,415L,422L,427L,431L,437L,442L,448L,453L,459L,463L,468L,475L,480L,485L,490L,495L,500L,506L,512L,516L,522L,527L,532L,538L,543L,548L,553L,559L,564L,569L,575L,579L,585L,591L,596L,601L,606L,612L,617L,622L,628L,632L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184916Inst : IEnumerable<long>
{
public static readonly long[] Value=A184916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184916.Bytes);
public long this[int i]=>Value[i];

public static A184916Inst Instance=new A184916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184917
{
public static readonly long[] Value={ 3L,7L,12L,16L,21L,26L,29L,34L,38L,43L,48L,52L,56L,60L,65L,70L,75L,79L,82L,87L,91L,97L,101L,105L,110L,113L,119L,123L,128L,132L,136L,141L,145L,150L,154L,158L,164L,167L,172L,176L,180L,185L,190L,194L,198L,203L,207L,212L,217L,221L,225L,229L,234L,239L,243L,248L,251L,256L,261L,265L,270L,274L,278L,283L,287L,292L,296L,301L,306L,309L,314L,318L,323L,328L,333L,336L,340L,345L,349L,355L,359L,362L,367L,371L,377L,381L,386L,389L,393L,399L,403L,408L,412L,416L,420L,425L,430L,434L,439L,443L,447L,452L,456L,461L,465L,470L,474L,478L,483L,487L,492L,497L,501L,505L,509L,514L,519L,523L,528L,531L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184917Inst : IEnumerable<long>
{
public static readonly long[] Value=A184917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184917.Bytes);
public long this[int i]=>Value[i];

public static A184917Inst Instance=new A184917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A184918
{
public static readonly long[] Value={ 2L,6L,10L,13L,17L,22L,24L,28L,32L,36L,40L,44L,47L,50L,54L,59L,63L,66L,69L,73L,76L,81L,85L,88L,92L,95L,100L,103L,107L,111L,114L,118L,122L,126L,129L,133L,138L,140L,144L,148L,151L,155L,160L,163L,166L,170L,174L,178L,182L,186L,189L,192L,197L,201L,204L,208L,211L,215L,219L,223L,227L,230L,233L,238L,241L,245L,249L,253L,257L,260L,264L,267L,271L,276L,280L,282L,286L,290L,293L,298L,302L,304L,308L,312L,317L,320L,324L,327L,330L,335L,339L,343L,346L,350L,353L,357L,361L,365L,369L,372L,376L,380L,383L,387L,391L,395L,398L,402L,406L,409L,414L,418L,421L,424L,428L,432L,436L,440L,444L,446L };
public static readonly IEnumerable<byte[]> Bytes=Value.Select(BitConverter.GetBytes);
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(Bytes);
}
public class A184918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A184918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A184918Inst : IEnumerable<long>
{
public static readonly long[] Value=A184918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A184918.Bytes);
public long this[int i]=>Value[i];

public static A184918Inst Instance=new A184918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

}