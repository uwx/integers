using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A257362
{
public static readonly long[] Value={ 41L,43L,47L,53L,61L,71L,83L,97L,113L,131L,151L,163L,167L,173L,179L,197L,199L,223L,227L,251L,263L,281L,307L,313L,347L,359L,367L,373L,379L,383L,397L,409L,419L,421L,439L,457L,461L,487L,499L,503L,523L,547L,563L,577L,593L,607L,641L,647L,653L,661L,673L,677L,691L };
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
public class A257362Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257362.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257362Inst : IEnumerable<long>
{
public static readonly long[] Value=A257362.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257362.Bytes);
public long this[int i]=>Value[i];

public static A257362Inst Instance=new A257362Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257363
{
public static readonly long[] Value={ 1L,3L,10L,33L,110L,369L,1247L,4248L,14603L,50724L,178314L,635526L,2300829L,8477382L,31842897L,122103276L,478372886L,1915188093L,7831613468L,32674683984L,138871668314L,600140517762L,2631926843602L,11690520554421L,52498671870181L,237966449687118L,1087246253873875L,5001141997115010L,23137102115963262L };
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
public class A257363Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257363.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257363Inst : IEnumerable<long>
{
public static readonly long[] Value=A257363.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257363.Bytes);
public long this[int i]=>Value[i];

public static A257363Inst Instance=new A257363Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257364
{
public static readonly long[] Value={ 11L,59L,47L,211L,23L,233L,181L,257L,109L,109L,13L,311L,929L,47L,389L,757L,1747L,13L,67L,2389L,1087L,569L,311L,853L,103L,5569L,1399L,3203L,10891L,3673L,3793L,1873L,4357L,41L,2297L,131L,3253L,6737L,2621L,5113L,2879L,953L,6379L,3539L,12343L,4337L,6067L,11939L,43441L,5179L };
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
public class A257364Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257364.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257364Inst : IEnumerable<long>
{
public static readonly long[] Value=A257364.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257364.Bytes);
public long this[int i]=>Value[i];

public static A257364Inst Instance=new A257364Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257365
{
public static readonly long[] Value={ 1L,1L,1L,1L,2L,1L,1L,4L,3L,1L,1L,6L,8L,4L,1L,1L,8L,16L,13L,5L,1L,1L,10L,28L,32L,19L,6L,1L,1L,12L,44L,68L,55L,26L,7L,1L,1L,14L,64L,128L,136L,86L,34L,8L,1L,1L,16L,88L,220L,296L,241L,126L,43L,9L,1L,1L,18L,116L,352L,584L,592L,393L,176L,53L,10L,1L };
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
public class A257365Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257365.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257365Inst : IEnumerable<long>
{
public static readonly long[] Value=A257365.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257365.Bytes);
public long this[int i]=>Value[i];

public static A257365Inst Instance=new A257365Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257366
{
public static readonly long[] Value={ 1L,3L,7L,43L,57L,307L,1068L,2943L,12943L,45807L,110443L,670807L,2733307L,25670807L,113561432L,123327057L,657922943L,17213170807L,7200891693L,148802454193L };
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
public class A257366Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257366.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257366Inst : IEnumerable<long>
{
public static readonly long[] Value=A257366.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257366.Bytes);
public long this[int i]=>Value[i];

public static A257366Inst Instance=new A257366Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257367
{
public static readonly long[] Value={ 4L,75L,186L,531L,627L,5216L,22843L,148050L,1061385L,1490407L,1562485L,9034704L,10422738L,31920786L,76343543L,78824242L,105791155L,111873121L,131515163L,549038887L,1318856915L,1394579379L,1630428366L,1639063828L,3710476544L,3996221763L,4524478925L,6172721935L };
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
public class A257367Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257367.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257367Inst : IEnumerable<long>
{
public static readonly long[] Value=A257367.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257367.Bytes);
public long this[int i]=>Value[i];

public static A257367Inst Instance=new A257367Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257368
{
public static readonly long[] Value={ 278L,528L,582L,826L,2385L,2585L,2868L,2872L,2875L,2878L,2885L,4782L,4832L,4872L,5278L,5328L,6872L,7238L,7258L,7268L,7582L,8232L,8266L,8275L,8278L,8284L,8522L,8524L,8528L,8628L,8732L,8822L,23385L,23628L,23782L,23826L,25582L,25668L,25785L,25856L,26238L,26878L };
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
public class A257368Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257368.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257368Inst : IEnumerable<long>
{
public static readonly long[] Value=A257368.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257368.Bytes);
public long this[int i]=>Value[i];

public static A257368Inst Instance=new A257368Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257369
{
public static readonly BigInteger[] Value={ 13L,BigInteger.Parse("695874886175252911063"),BigInteger.Parse("1567582627835236839763"),BigInteger.Parse("1750052554011927712483"),BigInteger.Parse("2257588388550898970503"),BigInteger.Parse("3789227751026345304613"),BigInteger.Parse("4654682384109074514133"),BigInteger.Parse("5022156579757255625623"),BigInteger.Parse("13599236099159166553033"),BigInteger.Parse("29894522822363684652103"),BigInteger.Parse("35718904544536715448883"),BigInteger.Parse("42421183685552747462323"),BigInteger.Parse("47624415490498763963983"),BigInteger.Parse("50069823850049036630533"),BigInteger.Parse("56294926786180569503953"),BigInteger.Parse("60877851518090858117803"),BigInteger.Parse("66871135379953148611303"),BigInteger.Parse("70743491366529526461853"),BigInteger.Parse("72039555441202354852783") };
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
public class A257369Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257369.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257369Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257369.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257369.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257369Inst Instance=new A257369Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257370
{
public static readonly BigInteger[] Value={ BigInteger.Parse("47710850533373130107"),BigInteger.Parse("347709450746519734877"),BigInteger.Parse("1099638576123052218257"),BigInteger.Parse("1169914227530138703617"),BigInteger.Parse("1522014304823128379267"),BigInteger.Parse("1620784518619319025977"),BigInteger.Parse("2639154464612254121537"),BigInteger.Parse("3259125690557440336637"),BigInteger.Parse("9042634271485192050677"),BigInteger.Parse("9239395687646993061197"),BigInteger.Parse("15571053758048293307807"),BigInteger.Parse("20628149050698694668167"),BigInteger.Parse("20947353617877810296177"),BigInteger.Parse("23182160505954925788317"),BigInteger.Parse("27814116054901200587567"),BigInteger.Parse("30406149669349341460577"),BigInteger.Parse("31607383424682394081757"),BigInteger.Parse("34254730511961158822627") };
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
public class A257370Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257370.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257370Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257370.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257370.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257370Inst Instance=new A257370Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257371
{
public static readonly long[] Value={ 3L,3L,5L,5L,5L,7L,8L,8L,8L,8L,8L,9L,12L,12L,12L,15L,15L,15L,17L,17L,18L,18L,18L,19L,29L };
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
public class A257371Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257371.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257371Inst : IEnumerable<long>
{
public static readonly long[] Value=A257371.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257371.Bytes);
public long this[int i]=>Value[i];

public static A257371Inst Instance=new A257371Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257372
{
public static readonly long[] Value={ 1L,6L,6L,15L,30L,21L,42L,15L,30L,33L,66L,1365L,2730L,3L,6L,255L,510L,399L,798L,165L,330L,69L,138L,1365L,2730L,3L,6L,435L,870L,7161L,14322L,255L,510L,3L,6L,959595L,1919190L,3L,6L,6765L,13530L,903L,1806L,345L,690L };
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
public class A257372Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257372.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257372Inst : IEnumerable<long>
{
public static readonly long[] Value=A257372.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257372.Bytes);
public long this[int i]=>Value[i];

public static A257372Inst Instance=new A257372Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257373
{
public static readonly BigInteger[] Value={ 13L,17L,BigInteger.Parse("1620784518619319025971"),BigInteger.Parse("2639154464612254121531"),BigInteger.Parse("3259125690557440336631"),BigInteger.Parse("37630850994954402655487"),BigInteger.Parse("47624415490498763963983"),BigInteger.Parse("53947453971035573715707"),BigInteger.Parse("78314167738064529047713"),BigInteger.Parse("83405687980406998933663"),BigInteger.Parse("110885131130067570042703"),BigInteger.Parse("124211857692162527019731") };
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
public class A257373Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257373.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257373Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257373.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257373.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257373Inst Instance=new A257373Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257374
{
public static readonly BigInteger[] Value={ BigInteger.Parse("734975534793324512717947"),BigInteger.Parse("753314125249587933791677") };
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
public class A257374Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257374.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257374Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257374.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257374.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257374Inst Instance=new A257374Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257375
{
public static readonly BigInteger[] Value={ 13L,BigInteger.Parse("47624415490498763963983"),BigInteger.Parse("78314167738064529047713"),BigInteger.Parse("83405687980406998933663"),BigInteger.Parse("110885131130067570042703"),BigInteger.Parse("163027495131423420474913") };
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
public class A257375Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257375.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257375Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257375.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257375.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257375Inst Instance=new A257375Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257376
{
public static readonly BigInteger[] Value={ BigInteger.Parse("1620784518619319025971"),BigInteger.Parse("2639154464612254121531"),BigInteger.Parse("3259125690557440336631"),BigInteger.Parse("124211857692162527019731") };
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
public class A257376Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257376.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257376Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257376.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257376.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257376Inst Instance=new A257376Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257377
{
public static readonly BigInteger[] Value={ 17L,BigInteger.Parse("37630850994954402655487"),BigInteger.Parse("53947453971035573715707"),BigInteger.Parse("174856263959258260646207"),BigInteger.Parse("176964638100452596444067"),BigInteger.Parse("207068890313310815346497"),BigInteger.Parse("247620555224812786876877"),BigInteger.Parse("322237784423505559739147") };
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
public class A257377Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257377.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257377Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257377.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257377.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257377Inst Instance=new A257377Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257378
{
public static readonly long[] Value={ 1L,5L,3L,3L,13L,3L,3L,9L,5L,13L,9L,3L,3L,5L,9L,7L,3L,3L,3L,5L,3L,7L,19L,5L,5L,33L,3L,7L,7L,9L,5L,15L,3L,21L,15L,7L,35L,89L,25L,15L,25L,49L,53L,45L,13L,15L,21L,31L,27L,3L,9L,33L,37L,23L,41L,41L,19L,9L,111L,7L,3L,89L,13L,39L,31L,17L,11L,101L,17L,37L,7L,51L,75L };
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
public class A257378Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257378.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257378Inst : IEnumerable<long>
{
public static readonly long[] Value=A257378.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257378.Bytes);
public long this[int i]=>Value[i];

public static A257378Inst Instance=new A257378Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257379
{
public static readonly long[] Value={ 3L,1L,1L,3L,3L,1L,3L,3L,5L,5L,9L,5L,7L,7L,3L,17L,11L,11L,7L,9L,11L,15L,3L,7L,9L,67L,3L,45L,3L,1L,33L,21L,15L,23L,17L,3L,7L,9L,19L,15L,17L,63L,51L,3L,9L,33L,53L,61L,13L,45L,75L,39L,83L,43L,7L,19L,13L,41L,5L,19L,31L,165L,13L,27L,3L,13L,135L,33L,31L,15L,33L,87L };
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
public class A257379Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257379.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257379Inst : IEnumerable<long>
{
public static readonly long[] Value=A257379.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257379.Bytes);
public long this[int i]=>Value[i];

public static A257379Inst Instance=new A257379Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257380
{
public static readonly long[] Value={ 9300L,119716L,1719620L,24720784L,349003536L,4925793856L,69733153264L,987300576900L,13970047948904L,197664647574276L,2797189028575200L,39584116251965476L,560147800897976784L,7926510787173264784L };
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
public class A257380Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257380.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257380Inst : IEnumerable<long>
{
public static readonly long[] Value=A257380.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257380.Bytes);
public long this[int i]=>Value[i];

public static A257380Inst Instance=new A257380Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257381
{
public static readonly BigInteger[] Value={ 119716L,1444804L,20611600L,343435024L,5413133476L,81296835876L,1247979436900L,19524520846336L,302481385728064L,4647415584865936L,71685607209222400L,1109793021380582449L,17154635437233106576UL,BigInteger.Parse("264743455290883440400") };
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
public class A257381Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257381.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257381Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257381.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257381.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257381Inst Instance=new A257381Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257382
{
public static readonly BigInteger[] Value={ 1719620L,20611600L,190904784L,2462144400L,38404362240L,560006768896L,7744856653728L,111070015128576L,1628167615958016L,23324716086770596L,329336531244891208L,4700007297889800484L,BigInteger.Parse("67568560725185179824") };
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
public class A257382Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257382.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257382Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257382.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257382.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257382Inst Instance=new A257382Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257383
{
public static readonly BigInteger[] Value={ 24720784L,343435024L,2462144400L,17165192256L,188932792896L,2578927657216L,33052610739600L,423586575525961L,5688022544240400L,75055105665973161L,939761719675086400L,11768233345435487376UL,BigInteger.Parse("151539464193951582736") };
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
public class A257383Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257383.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257383Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257383.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257383.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257383Inst Instance=new A257383Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257384
{
public static readonly BigInteger[] Value={ 349003536L,5413133476L,38404362240L,188932792896L,1137602635980L,11412302804100L,138013711391664L,1648856819029924L,19882370563708992L,251525584333213696L,3131622037210419536L,BigInteger.Parse("36423947898049945744") };
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
public class A257384Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257384.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257384Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257384.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257384.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257384Inst Instance=new A257384Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257385
{
public static readonly long[] Value={ 9300L,119716L,119716L,1719620L,1444804L,1719620L,24720784L,20611600L,20611600L,24720784L,349003536L,343435024L,190904784L,343435024L,349003536L,4925793856L,5413133476L,2462144400L,2462144400L,5413133476L,4925793856L,69733153264L };
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
public class A257385Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257385.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257385Inst : IEnumerable<long>
{
public static readonly long[] Value=A257385.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257385.Bytes);
public long this[int i]=>Value[i];

public static A257385Inst Instance=new A257385Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257386
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,51L,126L,316L,799L,2034L,5202L,13357L,34407L,88888L,230237L,597829L,1555962L,4058944L,10612102L,27807135L,73025751L,192204957L,507025163L,1340545113L,3552492126L };
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
public class A257386Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257386.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257386Inst : IEnumerable<long>
{
public static readonly long[] Value=A257386.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257386.Bytes);
public long this[int i]=>Value[i];

public static A257386Inst Instance=new A257386Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257387
{
public static readonly long[] Value={ 1L,1L,2L,4L,9L,21L,51L,127L,323L,834L,2179L,5743L,15238L,40637L,108800L,292200L,786703L,2122387L,5735596L,15522682L,42064028L,114117541L,309918698L,842489130L,2292332265L,6242655886L };
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
public class A257387Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257387.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257387Inst : IEnumerable<long>
{
public static readonly long[] Value=A257387.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257387.Bytes);
public long this[int i]=>Value[i];

public static A257387Inst Instance=new A257387Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257388
{
public static readonly long[] Value={ 1L,4L,17L,72L,306L,1304L,5573L,23888L,102702L,442904L,1915978L,8314480L,36195236L,158067312L,692475053L,3043191200L,13415404246L,59321085720L,263100680926L,1170347803440L,5221037429948L,23356788588752L,104772374565666L,471214329434208L,2124649562373708L,9603094073668208L };
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
public class A257388Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257388.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257388Inst : IEnumerable<long>
{
public static readonly long[] Value=A257388.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257388.Bytes);
public long this[int i]=>Value[i];

public static A257388Inst Instance=new A257388Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257389
{
public static readonly long[] Value={ 1L,0L,1L,1L,2L,2L,6L,6L,17L,21L,54L,74L,183L,272L,644L,1025L,2342L,3928L,8734L,15264L,33227L,59989L,128484L,238008L,503563L,952038L,1995955L,3835381L,7987092L,15548654L,32223061L,63388488L,130918071L,259724317L,535168956L,1069025128L };
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
public class A257389Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257389.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257389Inst : IEnumerable<long>
{
public static readonly long[] Value=A257389.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257389.Bytes);
public long this[int i]=>Value[i];

public static A257389Inst Instance=new A257389Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257390
{
public static readonly long[] Value={ 1L,0L,1L,4L,18L,80L,357L,1596L,7150L,32096L,144362L,650568L,2937316L,13286368L,60205805L,273290988L,1242639446L,5659468736L,25816338046L,117945079736L,539646216188L,2472638868960L,11345220210658L,52124831171544L,239792244636876L,1104495824173376L };
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
public class A257390Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257390.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257390Inst : IEnumerable<long>
{
public static readonly long[] Value=A257390.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257390.Bytes);
public long this[int i]=>Value[i];

public static A257390Inst Instance=new A257390Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257391
{
public static readonly BigInteger[] Value={ 29120L,32537600L,34093383680L,36011213418659840L,BigInteger.Parse("36888985097480437760"),BigInteger.Parse("38685331082014736871587840"),BigInteger.Parse("39614005699412557795646504960"),BigInteger.Parse("41538369916519054182462860998737920"),BigInteger.Parse("44601490313984496701256699111250939955118080"),BigInteger.Parse("45671926145323068271210017365594287580527984640") };
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
public class A257391Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257391.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257391Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257391.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257391.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257391Inst Instance=new A257391Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257392
{
public static readonly long[] Value={ 1L,2L,0L,0L,1L,2L,1L,0L,1L,1L,1L,2L,1L,0L,2L,1L,1L,1L,2L,3L,1L,1L,2L,1L,1L,1L,2L,3L,3L,1L,1L,2L,1L,2L,2L,1L,2L,1L,4L,2L,1L,2L,1L,1L,1L,4L,2L,0L,1L,4L,3L,3L,1L,2L,2L,2L,1L,2L,2L,2L,2L,0L,2L,4L,3L,2L,1L,3L,2L,3L,1L,2L,1L,0L,3L,4L,2L,2L,3L,3L,1L,3L,2L,1L,2L,3L,2L,2L,1L,1L,4L,2L,2L,1L,4L,5L };
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
public class A257392Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257392.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257392Inst : IEnumerable<long>
{
public static readonly long[] Value=A257392.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257392.Bytes);
public long this[int i]=>Value[i];

public static A257392Inst Instance=new A257392Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257393
{
public static readonly long[] Value={ 2L,3L,7L,13L,47L,61L,73L,107L,167L,179L,313L,347L,421L,479L,719L,863L,1153L,1213L,1283L,1307L,1523L,3467L,3733L,4007L,4621L,4787L,5087L,5113L,5413L,7523L,7703L,9817L,10333L,12347L,12539L,13381L,17027L,18553L,19717L,19813L,23399L,26003L,31873L,36097L,38833L };
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
public class A257393Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257393.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257393Inst : IEnumerable<long>
{
public static readonly long[] Value=A257393.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257393.Bytes);
public long this[int i]=>Value[i];

public static A257393Inst Instance=new A257393Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257394
{
public static readonly long[] Value={ 7L,8L,9L,8L,3L,4L,8L,5L,6L,9L,1L,0L,1L,1L,2L,2L,8L,5L,4L,4L,2L,6L,5L,1L,4L,6L,4L,7L,4L,6L,9L,3L,1L,2L,7L,1L,8L,4L,4L,4L,3L,4L,0L,5L,8L,4L,1L,8L,3L,1L,1L,6L,3L,8L,5L,3L,6L,6L,9L,3L,4L,6L,4L,7L,9L,5L,8L,9L,1L,4L,5L,6L,1L,4L,8L,1L,8L,0L,1L,6L,3L,5L,3L,3L,0L,9L,9L,2L,4L,4L,5L,6L,1L,2L,7L,6L,1L,2L,8L,5L,6L,8L,3L,9L,6L };
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
public class A257394Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257394.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257394Inst : IEnumerable<long>
{
public static readonly long[] Value=A257394.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257394.Bytes);
public long this[int i]=>Value[i];

public static A257394Inst Instance=new A257394Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257395
{
public static readonly long[] Value={ 1L,7L,6L,7L,1L,9L,5L,7L,8L,5L,6L,2L,9L,3L,7L,4L,3L,4L,7L,5L,7L,2L,1L,5L,9L,2L,6L,1L,8L,5L,7L,4L,1L,8L,6L,1L,1L,2L,5L,3L,7L,8L,0L,2L,9L,9L,3L,1L,3L,2L,0L,1L,3L,4L,9L,7L,3L,2L,3L,5L,3L,7L,2L,4L,8L,1L,3L,2L,5L,5L,7L,2L,6L,6L,2L,8L,1L,8L,4L,1L,4L,2L,8L,5L,7L,7L,3L,1L,8L,2L,3L,5L,1L,4L,7L,8L,6L,5L,7L,8L,1L,1L,0L,4L };
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
public class A257395Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257395.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257395Inst : IEnumerable<long>
{
public static readonly long[] Value=A257395.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257395.Bytes);
public long this[int i]=>Value[i];

public static A257395Inst Instance=new A257395Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257396
{
public static readonly long[] Value={ 2L,3L,2L,3L,3L,7L,7L,3L,1L,6L,5L,8L,6L,7L,3L,0L,8L,0L,4L,8L,7L,9L,7L,2L,5L,4L,7L,7L,1L,7L,5L,3L,5L,3L,9L,8L,1L,4L,2L,4L,0L,4L,4L,7L,6L,9L,2L,3L,4L,5L,5L,9L,8L,9L,3L,4L,1L,8L,8L,7L,9L,0L,1L,1L,8L,0L,8L,4L,0L,3L,1L,6L,3L,4L,2L,3L,5L,8L,2L,8L,5L,5L,3L,9L,0L,6L,0L,6L,7L,5L,6L,1L,9L,0L,2L,8L,2L,5L,7L,6L,2L,0L,3L,4L };
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
public class A257396Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257396.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257396Inst : IEnumerable<long>
{
public static readonly long[] Value=A257396.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257396.Bytes);
public long this[int i]=>Value[i];

public static A257396Inst Instance=new A257396Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257397
{
public static readonly long[] Value={ 8L,0L,0L,8L,4L,1L,5L,5L,3L,3L,8L,8L,0L,4L,5L,4L,5L,8L,4L,6L,4L,2L,2L,8L,3L,3L,4L,2L,5L,6L,8L,3L,5L,1L,3L,4L,2L,0L,2L,5L,9L,7L,7L,7L,6L,6L,0L,0L,0L,5L,3L,5L,5L,3L,0L,6L,5L,3L,1L,1L,7L,0L,3L,4L,5L,6L,2L,9L,1L,5L,3L,7L,2L,6L,3L,7L,9L,9L,7L,7L,9L,8L,7L,3L,4L,2L,8L,4L,2L,3L,5L,8L,9L,2L,1L,8L,5L,8L,6L,7L,7L,7L,5L,7L,7L,9L,7L };
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
public class A257397Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257397.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257397Inst : IEnumerable<long>
{
public static readonly long[] Value=A257397.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257397.Bytes);
public long this[int i]=>Value[i];

public static A257397Inst Instance=new A257397Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257398
{
public static readonly long[] Value={ 1L,1L,1L,2L,2L,3L,0L,1L,2L,0L,2L,0L,3L,2L,2L,3L,0L,2L,2L,2L,0L,0L,1L,0L,2L,2L,1L,4L,2L,4L,0L,0L,2L,0L,4L,1L,0L,0L,4L,2L,1L,0L,2L,2L,0L,0L,0L,2L,2L,4L,2L,1L,2L,4L,2L,2L,0L,1L,0L,0L,4L,0L,2L,4L,0L,0L,0L,2L,0L,2L,3L,0L,0L,2L,2L,2L,2L,3L,2L,0L,4L,0L,4L,2L,2L,0L,0L };
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
public class A257398Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257398.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257398Inst : IEnumerable<long>
{
public static readonly long[] Value=A257398.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257398.Bytes);
public long this[int i]=>Value[i];

public static A257398Inst Instance=new A257398Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257399
{
public static readonly long[] Value={ 1L,0L,0L,2L,1L,0L,0L,2L,1L,0L,0L,2L,2L,0L,0L,0L,2L,0L,0L,0L,3L,0L,0L,2L,0L,0L,0L,2L,1L,0L,0L,4L,2L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,3L,0L,0L,2L,2L,0L,0L,2L,2L,0L,0L,0L,3L,0L,0L,2L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,4L,2L,0L,0L,2L,0L,0L,0L,2L,0L,0L,0L };
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
public class A257399Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257399.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257399Inst : IEnumerable<long>
{
public static readonly long[] Value=A257399.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257399.Bytes);
public long this[int i]=>Value[i];

public static A257399Inst Instance=new A257399Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257400
{
public static readonly long[] Value={ 1L,1L,2L,2L,-1L,0L,-2L,0L,2L,0L,0L,-4L,-2L,0L,0L,0L,-1L,-4L,0L,2L,0L,0L,-2L,0L,-2L,1L,0L,-2L,0L,0L,0L,0L,2L,4L,-2L,0L,0L,0L,4L,0L,0L,-4L,0L,2L,4L,0L,0L,0L,-2L,1L,2L,4L,0L,0L,2L,0L,0L,4L,0L,-4L,0L,0L,0L,0L,-1L,0L,-4L,2L,4L,0L,0L,0L,0L,2L,0L,2L,-2L,0L,0L,0L,0L };
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
public class A257400Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257400.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257400Inst : IEnumerable<long>
{
public static readonly long[] Value=A257400.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257400.Bytes);
public long this[int i]=>Value[i];

public static A257400Inst Instance=new A257400Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257401
{
public static readonly long[] Value={ 0L,11L,20L };
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
public class A257401Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257401.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257401Inst : IEnumerable<long>
{
public static readonly long[] Value=A257401.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257401.Bytes);
public long this[int i]=>Value[i];

public static A257401Inst Instance=new A257401Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257402
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,1L,0L,0L,1L,0L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,1L,0L,0L,0L,0L,2L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,1L,0L,0L,1L,1L,0L,0L,1L,1L,0L,0L,1L,2L,0L,0L,1L,0L,0L,0L,0L,1L,0L };
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
public class A257402Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257402.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257402Inst : IEnumerable<long>
{
public static readonly long[] Value=A257402.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257402.Bytes);
public long this[int i]=>Value[i];

public static A257402Inst Instance=new A257402Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257403
{
public static readonly long[] Value={ 1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,2L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,1L,1L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,2L,0L };
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
public class A257403Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257403.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257403Inst : IEnumerable<long>
{
public static readonly long[] Value=A257403.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257403.Bytes);
public long this[int i]=>Value[i];

public static A257403Inst Instance=new A257403Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257404
{
public static readonly long[] Value={ 8L,18L,24L,50L,81L,98L,160L,242L,338L,375L,578L,722L,896L,1029L,1058L,1215L,1682L,1922L,2738L,3362L,3698L,3993L,4418L,5618L,6591L,6962L,7442L,8978L,10082L,10658L,12482L,13778L,14739L,15309L,15625L,15842L,18818L };
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
public class A257404Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257404.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257404Inst : IEnumerable<long>
{
public static readonly long[] Value=A257404.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257404.Bytes);
public long this[int i]=>Value[i];

public static A257404Inst Instance=new A257404Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257405
{
public static readonly long[] Value={ 1L,2L,3L,6L,5L,10L,7L,14L,4L,8L,11L,22L,13L,26L,12L,9L,17L,34L,19L,38L,16L,18L,23L,46L,20L,15L,21L,24L,29L,58L,31L,62L,28L,30L,25L,35L,37L,74L,32L,36L,41L,82L,43L,86L,40L,42L,47L,94L,44L,33L,27L,39L,53L,106L,48L,45L,50L,52L,59L,118L,61L,122L,54L,51L,57L,60L,67L };
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
public class A257405Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257405.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257405Inst : IEnumerable<long>
{
public static readonly long[] Value=A257405.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257405.Bytes);
public long this[int i]=>Value[i];

public static A257405Inst Instance=new A257405Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257406
{
public static readonly long[] Value={ 5L,2L,0L,8L,8L,5L,6L,1L,2L,6L,0L,1L,9L,7L,6L,8L,9L,1L,0L,8L,0L,1L,8L,7L,7L,3L,7L,5L,7L,9L,4L,5L,4L,4L,3L,9L,0L,6L,3L,6L,3L,8L,3L,5L,5L,4L,4L,6L,2L,8L,5L,3L,4L,9L,9L,7L,5L,3L,7L,5L,5L,8L,4L,2L,1L,1L,5L,4L,3L,2L,0L,7L,6L,2L,9L,4L,6L,3L,4L,7L,8L,5L,3L,9L,7L,8L,6L,6L,4L,1L,6L,0L,8L,0L,1L,8L,2L,9L,9L,6L,2L,3L,4L };
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
public class A257406Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257406.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257406Inst : IEnumerable<long>
{
public static readonly long[] Value=A257406.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257406.Bytes);
public long this[int i]=>Value[i];

public static A257406Inst Instance=new A257406Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257407
{
public static readonly long[] Value={ 1L,3L,5L,0L,6L,4L,3L,8L,8L,1L,0L,4L,7L,6L,7L,5L,5L,0L,2L,5L,2L,0L,1L,7L,4L,7L,3L,5L,3L,3L,8L,7L,2L,5L,8L,4L,1L,3L,4L,9L,5L,2L,2L,3L,6L,6L,9L,2L,4L,3L,5L,4L,5L,4L,5L,3L,2L,3L,2L,5L,3L,7L,0L,8L,8L,5L,7L,8L,7L,7L,8L,9L,0L,8L,3L,6L,1L,2L,7L,3L,6L,9L,0L,4L,0L,2L,3L,6L,0L,7L,7L,8L,2L,2L,4L,9L,1L,5L,6L,3L,6L,0L,9L,9L,4L,7L };
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
public class A257407Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257407.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257407Inst : IEnumerable<long>
{
public static readonly long[] Value=A257407.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257407.Bytes);
public long this[int i]=>Value[i];

public static A257407Inst Instance=new A257407Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257408
{
public static readonly long[] Value={ 1L,3L,4L,5L,7L,8L,11L,12L,13L,17L,19L,20L,23L,28L,29L,31L,37L,41L,43L,44L,47L,52L,53L,59L,61L,67L,68L,71L,73L,76L,79L,83L,89L,92L,97L,101L,103L,107L,109L,113L,116L,124L,127L,131L,137L,139L,148L,149L,151L,157L,163L,164L,167L,172L,173L,179L,181L,188L,191L,193L };
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
public class A257408Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257408.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257408Inst : IEnumerable<long>
{
public static readonly long[] Value=A257408.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257408.Bytes);
public long this[int i]=>Value[i];

public static A257408Inst Instance=new A257408Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257409
{
public static readonly long[] Value={ 9L,15L,16L,21L,24L,25L,27L,32L,33L,35L,36L,39L,40L,49L,51L,55L,56L,57L,60L,65L,69L,77L,84L,85L,87L,88L,91L,93L,95L,100L,104L,108L,111L,115L,119L,121L,123L,125L,129L,132L,133L,136L,140L,141L,143L,145L,152L,155L,156L,159L,161L,169L,177L,183L,184L,185L,187L,196L };
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
public class A257409Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257409.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257409Inst : IEnumerable<long>
{
public static readonly long[] Value=A257409.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257409.Bytes);
public long this[int i]=>Value[i];

public static A257409Inst Instance=new A257409Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257410
{
public static readonly long[] Value={ 45L,48L,63L,64L,72L,75L,80L,81L,99L,112L,117L,128L,147L,153L,171L,175L,176L,180L,200L,207L,208L,243L,245L,252L,261L,272L,275L,279L,300L,304L,324L,325L,333L,363L,368L,369L,387L,392L,396L,423L,425L,464L,468L,475L,477L,496L,507L,531L,539L,549L,575L,588L,592L };
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
public class A257410Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257410.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257410Inst : IEnumerable<long>
{
public static readonly long[] Value=A257410.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257410.Bytes);
public long this[int i]=>Value[i];

public static A257410Inst Instance=new A257410Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257411
{
public static readonly long[] Value={ 96L,105L,120L,135L,160L,165L,168L,189L,195L,216L,224L,231L,255L,256L,264L,273L,280L,285L,297L,312L,345L,351L,352L,357L,375L,385L,399L,408L,416L,420L,429L,435L,440L,455L,456L,459L,465L,483L,512L,513L,520L,540L,544L,552L,555L,561L,595L,608L,609L,615L,616L,621L };
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
public class A257411Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257411.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257411Inst : IEnumerable<long>
{
public static readonly long[] Value=A257411.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257411.Bytes);
public long this[int i]=>Value[i];

public static A257411Inst Instance=new A257411Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257412
{
public static readonly long[] Value={ 144L,192L,225L,320L,400L,405L,441L,448L,567L,648L,704L,784L,832L,891L,900L,1024L,1053L,1088L,1089L,1216L,1225L,1377L,1472L,1521L,1539L,1620L,1764L,1856L,1863L,1875L,1936L,1984L,2048L,2268L,2349L,2368L,2511L,2601L,2624L,2704L,2752L,2997L,3008L,3025L,3249L };
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
public class A257412Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257412.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257412Inst : IEnumerable<long>
{
public static readonly long[] Value=A257412.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257412.Bytes);
public long this[int i]=>Value[i];

public static A257412Inst Instance=new A257412Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257413
{
public static readonly long[] Value={ 240L,288L,315L,336L,360L,384L,432L,495L,504L,525L,528L,560L,585L,600L,624L,640L,675L,693L,735L,765L,792L,800L,816L,819L,825L,855L,880L,896L,912L,936L,975L,1035L,1040L,1071L,1104L,1125L,1176L,1197L,1215L,1224L,1232L,1260L,1275L,1287L,1305L,1323L,1360L,1368L };
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
public class A257413Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257413.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257413Inst : IEnumerable<long>
{
public static readonly long[] Value=A257413.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257413.Bytes);
public long this[int i]=>Value[i];

public static A257413Inst Instance=new A257413Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257414
{
public static readonly long[] Value={ 768L,1280L,1792L,2816L,3328L,3645L,4352L,4864L,5103L,5832L,5888L,7424L,7936L,8019L,9472L,9477L,10496L,11008L,12032L,12393L,13568L,13851L,14580L,15104L,15616L,16384L,16767L,17152L,18176L,18688L,20224L,20412L,21141L,21248L,22599L,22784L,24832L,25856L,26368L };
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
public class A257414Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257414.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257414Inst : IEnumerable<long>
{
public static readonly long[] Value=A257414.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257414.Bytes);
public long this[int i]=>Value[i];

public static A257414Inst Instance=new A257414Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257415
{
public static readonly long[] Value={ 480L,576L,672L,840L,864L,945L,1056L,1080L,1120L,1155L,1248L,1296L,1320L,1365L,1485L,1512L,1536L,1560L,1600L,1632L,1755L,1760L,1785L,1824L,1848L,1995L,2025L,2040L,2079L,2080L,2145L,2184L,2208L,2280L,2295L,2376L,2415L,2457L,2464L,2560L,2565L,2625L,2720L,2760L };
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
public class A257415Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257415.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257415Inst : IEnumerable<long>
{
public static readonly long[] Value=A257415.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257415.Bytes);
public long this[int i]=>Value[i];

public static A257415Inst Instance=new A257415Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257416
{
public static readonly long[] Value={ 720L,1008L,1152L,1200L,1575L,1584L,1800L,1872L,2205L,2352L,2448L,2475L,2736L,2800L,2925L,3072L,3200L,3312L,3528L,3675L,3825L,3888L,3920L,4176L,4275L,4400L,4464L,4851L,5120L,5175L,5200L,5328L,5445L,5733L,5808L,5904L,6075L,6192L,6272L,6300L,6525L,6768L,6800L };
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
public class A257416Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257416.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257416Inst : IEnumerable<long>
{
public static readonly long[] Value=A257416.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257416.Bytes);
public long this[int i]=>Value[i];

public static A257416Inst Instance=new A257416Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257417
{
public static readonly long[] Value={ 960L,1344L,1728L,2112L,2240L,2496L,2592L,2835L,3240L,3264L,3520L,3648L,4160L,4416L,4455L,4536L,4928L,5265L,5440L,5568L,5824L,5952L,6080L,6144L,6237L,6885L,7104L,7128L,7360L,7371L,7616L,7695L,7872L,8000L,8256L,8424L,8512L,9024L,9152L,9280L,9315L,9639L,9920L };
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
public class A257417Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257417.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257417Inst : IEnumerable<long>
{
public static readonly long[] Value=A257417.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257417.Bytes);
public long this[int i]=>Value[i];

public static A257417Inst Instance=new A257417Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257418
{
public static readonly long[] Value={ 2L,3L,5L,8L,13L,23L,41L,77L,145L,281L,545L,1073L,2113L,4193L,8321L,16577L,33025L,65921L,131585L,262913L,525313L,1050113L,2099201L,4197377L,8392705L,16783361L,33562625L,67121153L,134234113L,268460033L,536903681L,1073790977L,2147549185L,4295065601L,8590065665L };
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
public class A257418Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257418.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257418Inst : IEnumerable<long>
{
public static readonly long[] Value=A257418.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257418.Bytes);
public long this[int i]=>Value[i];

public static A257418Inst Instance=new A257418Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257419
{
public static readonly long[] Value={ 512L,7652L,117324L,1770206L,12316842L,115919394L,1037269100L,6191314193L,57799643410L,478127487069L,2903676329504L,27615631745955L,219195987569254L,1325497215293808L };
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
public class A257419Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257419.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257419Inst : IEnumerable<long>
{
public static readonly long[] Value=A257419.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257419.Bytes);
public long this[int i]=>Value[i];

public static A257419Inst Instance=new A257419Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257420
{
public static readonly long[] Value={ 2616L,7652L,30309L,119393L,403951L,1293242L,4098078L,12497488L,37528750L,111339861L,326552920L,949466125L,2746182574L,7900552664L,22633690594L,64617935573L,183950154022L,522353720305L,1480269737481L,4187439072469L };
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
public class A257420Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257420.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257420Inst : IEnumerable<long>
{
public static readonly long[] Value=A257420.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257420.Bytes);
public long this[int i]=>Value[i];

public static A257420Inst Instance=new A257420Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257421
{
public static readonly long[] Value={ 10684L,27244L,117324L,449022L,1290910L,3917190L,11883298L,33766938L,96478988L,272492320L,759572898L,2120432736L,5906478692L,16369510406L,45291725362L,125081097988L,344778228786L,949378792506L,2611483388044L,7175959675462L };
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
public class A257421Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257421.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257421Inst : IEnumerable<long>
{
public static readonly long[] Value=A257421.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257421.Bytes);
public long this[int i]=>Value[i];

public static A257421Inst Instance=new A257421Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257422
{
public static readonly long[] Value={ 41140L,103575L,450756L,1770206L,4442466L,13233402L,36058660L,94181694L,259847932L,722844592L,1965855694L,5405634454L,14813746242L,40504964992L,111029975004L,304364243354L,832977215094L,2280046783862L,6239422982964L };
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
public class A257422Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257422.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257422Inst : IEnumerable<long>
{
public static readonly long[] Value=A257422.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257422.Bytes);
public long this[int i]=>Value[i];

public static A257422Inst Instance=new A257422Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257423
{
public static readonly long[] Value={ 150016L,367929L,1557227L,5985744L,12316842L,36423140L,96141548L,259492076L,731002818L,2006564512L,5318291482L,14692484638L,40355053494L,110377628368L,302224479476L,826432640142L,2255634882902L,6168274420830L,16861966553132L };
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
public class A257423Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257423.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257423Inst : IEnumerable<long>
{
public static readonly long[] Value=A257423.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257423.Bytes);
public long this[int i]=>Value[i];

public static A257423Inst Instance=new A257423Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257424
{
public static readonly long[] Value={ 514920L,1246585L,5347670L,19771628L,39029574L,115919394L,317271378L,756210536L,2131836574L,5828147664L,15609807360L,43074413716L,116962517460L,315815849814L,863675994118L,2358777950090L,6431658379770L,17567133145546L,47951743101422L };
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
public class A257424Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257424.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257424Inst : IEnumerable<long>
{
public static readonly long[] Value=A257424.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257424.Bytes);
public long this[int i]=>Value[i];

public static A257424Inst Instance=new A257424Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257425
{
public static readonly long[] Value={ 1700100L,4137316L,18009368L,64652177L,121832476L,356678661L,1037269100L,2359203628L,7099788830L,18202585668L,46382073874L,125815055340L,344959665026L,927065687056L,2543518276740L,6912822214852L,18798048722510L,51304587059146L };
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
public class A257425Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257425.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257425Inst : IEnumerable<long>
{
public static readonly long[] Value=A257425.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257425.Bytes);
public long this[int i]=>Value[i];

public static A257425Inst Instance=new A257425Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257426
{
public static readonly long[] Value={ 512L,2616L,2616L,10684L,7652L,10684L,41140L,27244L,30309L,41140L,150016L,103575L,117324L,119393L,150016L,514920L,367929L,450756L,449022L,403951L,514920L,1700100L,1246585L,1557227L,1770206L,1290910L,1293242L,1700100L,5487356L,4137316L,5347670L };
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
public class A257426Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257426.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257426Inst : IEnumerable<long>
{
public static readonly long[] Value=A257426.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257426.Bytes);
public long this[int i]=>Value[i];

public static A257426Inst Instance=new A257426Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257427
{
public static readonly long[] Value={ 2616L,7652L,27244L,103575L,367929L,1246585L,4137316L,13275095L,41621545L,128299778L,389217704L,1165610625L,3456006395L,10159155410L,29647440717L,85997742083L,248174114409L,713062049952L,2041229428915L,5824856350604L };
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
public class A257427Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257427.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257427Inst : IEnumerable<long>
{
public static readonly long[] Value=A257427.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257427.Bytes);
public long this[int i]=>Value[i];

public static A257427Inst Instance=new A257427Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257428
{
public static readonly long[] Value={ 10684L,30309L,117324L,450756L,1557227L,5347670L,18009368L,56974502L,175429523L,529347970L,1564618576L,4562215480L,13164718505L,37620437052L,106719838002L,300955191132L,844418347509L,2359570864166L,6571196297634L,18247737560110L };
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
public class A257428Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257428.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257428Inst : IEnumerable<long>
{
public static readonly long[] Value=A257428.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257428.Bytes);
public long this[int i]=>Value[i];

public static A257428Inst Instance=new A257428Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257429
{
public static readonly long[] Value={ 41140L,119393L,449022L,1770206L,5985744L,19771628L,64652177L,195603505L,586920722L,1743331948L,5079106522L,14663485366L,42004087573L,119219661191L,336143582507L,942853480005L,2631756218200L,7318423088042L,20289444965118L };
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
public class A257429Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257429.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257429Inst : IEnumerable<long>
{
public static readonly long[] Value=A257429.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257429.Bytes);
public long this[int i]=>Value[i];

public static A257429Inst Instance=new A257429Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257430
{
public static readonly long[] Value={ 150016L,403951L,1290910L,4442466L,12316842L,39029574L,121832476L,359681533L,1066288882L,3126365543L,8921825684L,25527972436L,72826289929L,206321352365L,583012447599L,1642831496480L,4611094251243L,12910731728619L,36064024641002L };
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
public class A257430Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257430.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257430Inst : IEnumerable<long>
{
public static readonly long[] Value=A257430.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257430.Bytes);
public long this[int i]=>Value[i];

public static A257430Inst Instance=new A257430Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257431
{
public static readonly long[] Value={ 514920L,1293242L,3917190L,13233402L,36423140L,115919394L,356678661L,1013024839L,2950063325L,8706010338L,24924494772L,71250809523L,201815907569L,564593588950L,1576308803788L,4393237742809L,12206840093658L,33862403008984L };
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
public class A257431Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257431.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257431Inst : IEnumerable<long>
{
public static readonly long[] Value=A257431.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257431.Bytes);
public long this[int i]=>Value[i];

public static A257431Inst Instance=new A257431Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257432
{
public static readonly long[] Value={ 1700100L,4098078L,11883298L,36058660L,96141548L,317271378L,1037269100L,3132168159L,9367464149L,27528765545L,76077345023L,212817553945L,593399397630L,1641266694259L,4530230346513L,12467703705109L,34164329699230L };
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
public class A257432Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257432.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257432Inst : IEnumerable<long>
{
public static readonly long[] Value=A257432.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257432.Bytes);
public long this[int i]=>Value[i];

public static A257432Inst Instance=new A257432Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257433
{
public static readonly long[] Value={ 2L,4L,5L,7L,0L,2L,4L,7L,3L,8L,2L,2L,0L,8L,0L,0L,6L,2L,3L,0L,3L,9L,4L,5L,4L,1L,4L,7L,6L,5L,1L,1L,7L,9L,5L,4L,3L,2L,3L,6L,5L,9L,7L,9L,0L,9L,0L,3L,3L,7L,8L,4L,4L,2L,0L,9L,6L,4L,7L,9L,4L,4L,9L,5L,2L,8L,0L,6L,1L,2L,6L,3L,4L,2L,6L,0L,4L,9L,4L,9L,6L,1L,7L,0L,2L,3L,7L,0L,2L,9L,2L,6L,5L,5L,7L,2L,8L,2L,0L,6L,6L,1L,8L,3L };
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
public class A257433Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257433.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257433Inst : IEnumerable<long>
{
public static readonly long[] Value=A257433.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257433.Bytes);
public long this[int i]=>Value[i];

public static A257433Inst Instance=new A257433Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257434
{
public static readonly long[] Value={ 2L,7L,4L,7L,6L,8L,2L,6L,4L,6L,7L,2L,7L,4L,1L,2L,6L,0L,1L,3L,9L,1L,4L,8L,8L,4L,8L,2L,6L,9L,1L,4L,9L,9L,6L,9L,5L,8L,6L,1L,6L,3L,9L,3L,9L,5L,1L,3L,2L,3L,5L,5L,5L,1L,2L,0L,5L,2L,2L,9L,9L,1L,4L,8L,1L,1L,2L,5L,3L,9L,0L,6L,7L,6L,4L,5L,5L,5L,0L,0L,6L,0L,4L,1L,9L,9L,7L,8L,6L,6L,4L,0L,0L,6L,6L,4L,5L,8L,3L,7L,3L };
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
public class A257434Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257434.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257434Inst : IEnumerable<long>
{
public static readonly long[] Value=A257434.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257434.Bytes);
public long this[int i]=>Value[i];

public static A257434Inst Instance=new A257434Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257435
{
public static readonly long[] Value={ 9L,0L,0L,4L,2L,4L,6L,0L,0L,3L,8L,9L,7L,0L,7L,7L,5L,7L,8L,5L,8L,8L,2L,7L,5L,8L,9L,0L,2L,9L,0L,4L,9L,4L,8L,5L,8L,2L,9L,9L,4L,3L,9L,5L,7L,6L,6L,6L,6L,1L,8L,7L,6L,5L,5L,9L,5L,1L,5L,7L,3L,1L,8L,3L,9L,1L,0L,5L,4L,4L,2L,0L,3L,6L,7L,5L,6L,5L,4L,7L,4L,9L,9L,6L,2L,3L,2L,3L,1L,5L,3L,0L,2L,5L,7L,1L,2L,4L,8L,2L,2L,8L,7L,8L,6L };
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
public class A257435Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257435.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257435Inst : IEnumerable<long>
{
public static readonly long[] Value=A257435.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257435.Bytes);
public long this[int i]=>Value[i];

public static A257435Inst Instance=new A257435Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257436
{
public static readonly long[] Value={ 8L,5L,5L,3L,8L,9L,2L,4L,5L,8L,3L,8L,5L,6L,4L,6L,4L,0L,9L,7L,2L,4L,8L,1L,0L,3L,6L,7L,4L,0L,4L,5L,6L,5L,5L,2L,2L,2L,6L,8L,3L,1L,1L,9L,7L,3L,1L,5L,5L,7L,3L,4L,8L,0L,3L,9L,8L,1L,4L,2L,0L,0L,4L,0L,4L,2L,5L,6L,2L,0L,1L,2L,9L,8L,6L,7L,7L,4L,5L,9L,7L,1L,5L,7L,0L,1L,5L,6L,6L,0L,3L,9L,8L,2L,9L,8L,2L,6L,5L,0L,5L,4L,6L,6L,6L,7L,5L };
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
public class A257436Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257436.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257436Inst : IEnumerable<long>
{
public static readonly long[] Value=A257436.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257436.Bytes);
public long this[int i]=>Value[i];

public static A257436Inst Instance=new A257436Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257437
{
public static readonly long[] Value={ 9L,1L,2L,0L,5L,5L,0L,8L,9L,3L,7L,2L,7L,1L,8L,4L,0L,0L,0L,1L,8L,8L,2L,8L,6L,5L,5L,6L,9L,3L,0L,9L,7L,5L,3L,4L,4L,5L,1L,1L,4L,2L,9L,1L,1L,9L,8L,0L,3L,1L,8L,7L,4L,6L,8L,4L,3L,6L,2L,4L,2L,6L,1L,7L,8L,4L,7L,8L,3L,6L,9L,1L,3L,8L,3L,6L,5L,2L,7L,4L,1L,1L,1L,5L,0L,3L,4L,6L,4L,5L,0L,4L,7L,5L,7L,7L,3L,5L,5L,7L,2L,6L,5L };
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
public class A257437Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257437.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257437Inst : IEnumerable<long>
{
public static readonly long[] Value=A257437.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257437.Bytes);
public long this[int i]=>Value[i];

public static A257437Inst Instance=new A257437Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257438
{
public static readonly long[] Value={ 8L,9L,3L,6L,7L,1L,4L,2L,3L,4L,6L,0L,9L,6L,3L,5L,5L,4L,3L,0L,2L,0L,6L,9L,8L,5L,4L,5L,8L,3L,5L,4L,6L,0L,0L,7L,5L,4L,7L,5L,5L,8L,0L,9L,4L,7L,9L,6L,3L,2L,8L,0L,7L,8L,2L,2L,0L,3L,0L,8L,5L,8L,4L,8L,7L,8L,1L,5L,7L,6L,4L,1L,7L,7L,0L,4L,9L,2L,9L,1L,5L,0L,7L,9L,6L,7L,0L,5L,1L,6L,3L,8L,4L,2L,2L,3L,7L,2L,8L,1L,4L,8L,0L,3L };
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
public class A257438Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257438.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257438Inst : IEnumerable<long>
{
public static readonly long[] Value=A257438.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257438.Bytes);
public long this[int i]=>Value[i];

public static A257438Inst Instance=new A257438Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257439
{
public static readonly long[] Value={ 30L,38L,47L,71L,107L,161L,239L,353L,521L,767L,1127L,1655L,2429L,3563L,5225L,7661L,11231L,16463L,24131L,35369L,51839L,75977L,111353L,163199L,239183L,350543L,513749L,752939L,1103489L,1617245L };
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
public class A257439Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257439.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257439Inst : IEnumerable<long>
{
public static readonly long[] Value=A257439.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257439.Bytes);
public long this[int i]=>Value[i];

public static A257439Inst Instance=new A257439Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257440
{
public static readonly long[] Value={ 30L,36L,39L,49L,65L,90L,128L,186L,269L,392L,573L,836L,1223L,1791L,2621L,3839L,5625L,8240L,12074L,17694L,25928L,37997L,55686L,81608L,119600L,175281L,256883L,376478L,551754L,808631L,1185104L,1736853L,2545478L,3730577L,5467425L,8012897L,11743469L };
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
public class A257440Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257440.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257440Inst : IEnumerable<long>
{
public static readonly long[] Value=A257440.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257440.Bytes);
public long this[int i]=>Value[i];

public static A257440Inst Instance=new A257440Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257441
{
public static readonly long[] Value={ 36L,38L,41L,51L,68L,95L,134L,191L,275L,398L,578L,842L,1229L,1796L,2627L,3845L,5630L,8246L,12080L,17699L,25934L,38003L,55691L,81614L,119606L,175286L,256889L,376484L,551759L,808637L,1185110L,1736858L,2545484L,3730583L,5467430L,8012903L,11743475L };
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
public class A257441Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257441.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257441Inst : IEnumerable<long>
{
public static readonly long[] Value=A257441.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257441.Bytes);
public long this[int i]=>Value[i];

public static A257441Inst Instance=new A257441Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257442
{
public static readonly long[] Value={ 39L,41L,47L,59L,77L,104L,143L,200L,284L,407L,587L,851L,1238L,1805L,2636L,3854L,5639L,8255L,12089L,17708L,25943L,38012L,55700L,81623L,119615L,175295L,256898L,376493L,551768L,808646L,1185119L,1736867L,2545493L,3730592L,5467439L,8012912L,11743484L };
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
public class A257442Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257442.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257442Inst : IEnumerable<long>
{
public static readonly long[] Value=A257442.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257442.Bytes);
public long this[int i]=>Value[i];

public static A257442Inst Instance=new A257442Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257443
{
public static readonly long[] Value={ 49L,51L,59L,71L,89L,116L,155L,212L,296L,419L,599L,863L,1250L,1817L,2648L,3866L,5651L,8267L,12101L,17720L,25955L,38024L,55712L,81635L,119627L,175307L,256910L,376505L,551780L,808658L,1185131L,1736879L,2545505L,3730604L,5467451L,8012924L,11743496L };
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
public class A257443Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257443.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257443Inst : IEnumerable<long>
{
public static readonly long[] Value=A257443.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257443.Bytes);
public long this[int i]=>Value[i];

public static A257443Inst Instance=new A257443Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257444
{
public static readonly long[] Value={ 65L,68L,77L,89L,107L,134L,173L,230L,314L,437L,617L,881L,1268L,1835L,2666L,3884L,5669L,8285L,12119L,17738L,25973L,38042L,55730L,81653L,119645L,175325L,256928L,376523L,551798L,808676L,1185149L,1736897L,2545523L,3730622L,5467469L,8012942L,11743514L };
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
public class A257444Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257444.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257444Inst : IEnumerable<long>
{
public static readonly long[] Value=A257444.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257444.Bytes);
public long this[int i]=>Value[i];

public static A257444Inst Instance=new A257444Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257445
{
public static readonly long[] Value={ 90L,95L,104L,116L,134L,161L,200L,257L,341L,464L,644L,908L,1295L,1862L,2693L,3911L,5696L,8312L,12146L,17765L,26000L,38069L,55757L,81680L,119672L,175352L,256955L,376550L,551825L,808703L,1185176L,1736924L,2545550L,3730649L,5467496L,8012969L,11743541L };
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
public class A257445Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257445.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257445Inst : IEnumerable<long>
{
public static readonly long[] Value=A257445.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257445.Bytes);
public long this[int i]=>Value[i];

public static A257445Inst Instance=new A257445Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257446
{
public static readonly long[] Value={ 128L,134L,143L,155L,173L,200L,239L,296L,380L,503L,683L,947L,1334L,1901L,2732L,3950L,5735L,8351L,12185L,17804L,26039L,38108L,55796L,81719L,119711L,175391L,256994L,376589L,551864L,808742L,1185215L,1736963L,2545589L,3730688L,5467535L,8013008L };
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
public class A257446Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257446.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257446Inst : IEnumerable<long>
{
public static readonly long[] Value=A257446.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257446.Bytes);
public long this[int i]=>Value[i];

public static A257446Inst Instance=new A257446Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257447
{
public static readonly long[] Value={ 30L,36L,36L,39L,38L,39L,49L,41L,41L,49L,65L,51L,47L,51L,65L,90L,68L,59L,59L,68L,90L,128L,95L,77L,71L,77L,95L,128L,186L,134L,104L,89L,89L,104L,134L,186L,269L,191L,143L,116L,107L,116L,143L,191L,269L,392L,275L,200L,155L,134L,134L,155L,200L,275L,392L,573L,398L,284L,212L,173L };
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
public class A257447Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257447.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257447Inst : IEnumerable<long>
{
public static readonly long[] Value=A257447.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257447.Bytes);
public long this[int i]=>Value[i];

public static A257447Inst Instance=new A257447Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257448
{
public static readonly long[] Value={ 1L,9L,37L,111L,283L,657L,1441L,3051L,6319L,12909L,26149L,52695L,105859L,212265L,425161L,851043L,1702903L,3406725L,6814477L,13630095L,27261451L,54524289L,109050097L,218101851L,436205503L,872412957L,1744828021L,3489658311L,6979319059L,13958640729L };
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
public class A257448Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257448.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257448Inst : IEnumerable<long>
{
public static readonly long[] Value=A257448.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257448.Bytes);
public long this[int i]=>Value[i];

public static A257448Inst Instance=new A257448Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257449
{
public static readonly long[] Value={ 1L,17L,99L,373L,1115L,2901L,6907L,15509L,33483L,70405L,145451L,296997L,601819L,1213493L,2439195L,4893301L,9804587L,19630629L,39286603L,78602885L,157240251L,314520277L,629086139L,1258224213L,2516507275L,5033080901L,10066236267L,20132555749L,40265204123L };
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
public class A257449Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257449.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257449Inst : IEnumerable<long>
{
public static readonly long[] Value=A257449.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257449.Bytes);
public long this[int i]=>Value[i];

public static A257449Inst Instance=new A257449Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257450
{
public static readonly long[] Value={ 1L,33L,277L,1335L,4771L,14193L,37417L,90795L,207871L,456693L,974437L,2036655L,4195771L,8558073L,17337697L,34964595L,70300471L,141070653L,282727837L,566179575L,1133243251L,2267556033L,4536394777L,9074315835L,18150434671L,36302985093L,72608437717L,145219736895L };
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
public class A257450Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257450.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257450Inst : IEnumerable<long>
{
public static readonly long[] Value=A257450.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257450.Bytes);
public long this[int i]=>Value[i];

public static A257450Inst Instance=new A257450Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257451
{
public static readonly long[] Value={ 2L,3L,3L,1L,1L,2L,2L,3L,7L,0L,4L,1L,4L,4L,2L,2L,6L,1L,3L,6L,6L,7L,8L,3L,5L,9L,5L,5L,9L,1L,7L,1L,2L,1L,3L,3L,8L,2L,6L,9L,0L,7L,7L,6L,9L,5L,3L,8L,6L,1L,1L,4L,5L,7L,5L,1L,0L,9L,7L,3L,7L,2L,9L,3L,3L,9L,3L,2L,3L,0L,8L,1L,7L,4L,3L,2L,7L,1L,6L,6L,7L,3L,8L,4L,2L,1L,5L,4L,2L,5L,7L,1L,0L,4L,3L,9L,3L,0L,1L,4L,0L,8L,7L,4L,5L };
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
public class A257451Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257451.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257451Inst : IEnumerable<long>
{
public static readonly long[] Value=A257451.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257451.Bytes);
public long this[int i]=>Value[i];

public static A257451Inst Instance=new A257451Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257452
{
public static readonly long[] Value={ 7L,2L,4L,6L,1L,1L,3L,5L,3L,7L,7L,6L,7L,0L,8L,4L,7L,5L,7L,3L,8L,9L,9L,0L,4L,5L,3L,5L,2L,5L,6L,3L,1L,7L,8L,4L,3L,4L,7L,8L,6L,5L,1L,0L,1L,8L,3L,8L,3L,9L,1L,7L,1L,4L,9L,5L,9L,3L,9L,9L,8L,6L,8L,4L,8L,5L,3L,3L,5L,8L,5L,6L,6L,3L,2L,9L,2L,0L,6L,6L,5L,7L,9L,6L,5L,0L,4L,6L,4L,9L,9L,1L,2L,7L,0L,7L,5L,0L,1L,4L,9L,1L,6L,0L,0L };
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
public class A257452Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257452.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257452Inst : IEnumerable<long>
{
public static readonly long[] Value=A257452.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257452.Bytes);
public long this[int i]=>Value[i];

public static A257452Inst Instance=new A257452Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257453
{
public static readonly BigInteger[] Value={ 1L,0L,3L,-24L,-287L,-2480L,-6061L,196504L,6666465L,124381728L,1152761219L,-16400751928L,-1124717924351L,-33594921946768L,-573356313677421L,3172375291503480L,680727732593163841L,BigInteger.Parse("30107084674604991040"),BigInteger.Parse("772334689398136241795"),BigInteger.Parse("2396611523246866389928"),BigInteger.Parse("-1018886965683104743074399") };
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
public class A257453Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257453.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257453Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257453.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257453.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257453Inst Instance=new A257453Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257454
{
public static readonly BigInteger[] Value={ 1L,8L,35L,80L,-959L,-31176L,-434029L,-2353376L,47273761L,2216299240L,54409114979L,709671322224L,-7010555032415L,-769095804780520L,-27981768126212461L,-591718277116485568L,773179823364059329L,BigInteger.Parse("753403954307904026568"),BigInteger.Parse("40453080644744591090723"),BigInteger.Parse("1239578120382146959699600") };
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
public class A257454Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257454.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257454Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A257454.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257454.Bytes);
public BigInteger this[int i]=>Value[i];

public static A257454Inst Instance=new A257454Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257455
{
public static readonly long[] Value={ 1L,2L,3L,5L,4L,7L,6L,13L,9L,24L,8L,26L,10L,28L,29L,34L,11L,39L,12L,65L,16L,36L,14L,41L,17L,43L,31L,55L,15L,86L,18L,45L,44L,57L,21L,84L,19L,59L,33L,78L,20L,243L,22L,98L,62L,82L,23L,113L,25L,80L,37L,96L,27L,115L,32L,129L,46L,104L,30L,164L,35L,106L,72L,108L,40L };
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
public class A257455Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257455.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257455Inst : IEnumerable<long>
{
public static readonly long[] Value=A257455.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257455.Bytes);
public long this[int i]=>Value[i];

public static A257455Inst Instance=new A257455Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257456
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,7L,8L,9L,10L,11L,13L,12L,16L,15L,18L,14L,20L,17L,24L,23L,22L,19L,28L,21L,26L,25L,33L,27L,40L,29L,31L,35L,36L,30L,42L,32L,44L,37L,38L,34L,50L,39L,46L,45L,48L,41L,52L,43L,54L,47L,57L,49L,61L,51L,64L,55L,59L,53L,68L,56L,66L,58L,70L,60L,72L,62L };
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
public class A257456Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257456.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257456Inst : IEnumerable<long>
{
public static readonly long[] Value=A257456.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257456.Bytes);
public long this[int i]=>Value[i];

public static A257456Inst Instance=new A257456Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257457
{
public static readonly long[] Value={ 2L,3L,4L,6L,8L,10L,11L,12L,14L,15L,18L,19L,20L,22L,23L,27L,30L,35L,38L,42L,47L,48L,49L,52L,53L,54L,60L,61L,63L,64L,69L,70L,73L,74L,83L,85L,87L,89L,92L,94L,97L,102L,112L,114L,116L,117L,120L,125L,127L,128L,134L,136L,139L,146L,149L,151L,153L,155L,156L,158L,159L };
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
public class A257457Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257457.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257457Inst : IEnumerable<long>
{
public static readonly long[] Value=A257457.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257457.Bytes);
public long this[int i]=>Value[i];

public static A257457Inst Instance=new A257457Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257458
{
public static readonly long[] Value={ 1L,2L,3L,4L,5L,6L,8L,9L,10L,11L,12L,13L,14L,15L,17L,18L,19L,20L,22L,23L,25L,27L,30L,31L,34L,35L,38L,42L,45L,47L,48L,49L,52L,53L,54L,60L,61L,63L,64L,66L,69L,70L,71L,73L,74L,81L,83L,85L,87L,89L,92L,94L,97L,100L,102L,108L,112L,114L,116L,117L,120L,125L,127L,128L };
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
public class A257458Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257458.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257458Inst : IEnumerable<long>
{
public static readonly long[] Value=A257458.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257458.Bytes);
public long this[int i]=>Value[i];

public static A257458Inst Instance=new A257458Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257459
{
public static readonly long[] Value={ 2L,1L,5L,1L,17L,1L,8L,1L,2L,6L,1L,0L,2L,1L,3L,9L,18L,4L,210L,6L,7L,3L,2L,6L,1L,2L,1L,2L,1L,2L,4L,3L,2L,24L,3L,1L,1L,6L,5L,11L,2L,1L,11L,1L,12L,6L,1L,7L,3L,39L,2L,2L,1L,2L,9L,3L,5L,1L,6L,2L,3L,2L,180L,3L,15L,17L,24L,1L,5L,1L,2L,2L,1L,64L,7L,6L,3L,24L,2L,1L,2L,1L,6L,16L,1L,9L,8L,6L,17L,4L,6L,2L,1L,9L,30L,2L,6L,44L,1L,6L };
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
public class A257459Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257459.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257459Inst : IEnumerable<long>
{
public static readonly long[] Value=A257459.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257459.Bytes);
public long this[int i]=>Value[i];

public static A257459Inst Instance=new A257459Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257460
{
public static readonly long[] Value={ 2L,1L,2L,0L,3L,1L,2L,1L,2L,48L,1L,10L,2L,3L,3L,3L,9L,1L,1L,2L,66L,1L,2L,8L,1L,2L,6L,3L,1L,3L,1L,2L,3L,6L,8L,9L,7L,1L,3L,2L,2L,3L,17L,4L,2L,1L,3L,1L,2L,1L,3L,2L,1L,5L,17L,5L,8L,16L,1L,3L,1L,8L,6L,2L,1L,3L,3L,2184L,6L,6L,3L,2L,1L,3L,1L,2L,2L,4L,2L,3L,3L,1L,2L,1L,1L,3L,6L,15L,5L,1L,48L,2L,1L,2L,7L,2L,47L,2L,1L,1L };
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
public class A257460Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257460.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257460Inst : IEnumerable<long>
{
public static readonly long[] Value=A257460.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257460.Bytes);
public long this[int i]=>Value[i];

public static A257460Inst Instance=new A257460Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A257461
{
public static readonly long[] Value={ 1L,0L,1L,1L,5L,1L,1L,1L,1L,2L,28L,1L,1L,1L,1L,2L,1L,1L,4L,1L,1L,3L,1L,2L,90L,1L,1L,2L,8L,2L,1L,1L,2L,1L,1L,2L,1L,4L,6L,8L,3L,2L,3L,4L,1L,1L,5L,1L,5L,60L,1L,1L,5L,6L,1L,2L,1L,1L,2L,1L,10L,1L,1L,1L,5L,2L,1L,3L,4L,1L,1L,2L,4L,1L,3L,4L,3L,2L,1L,1L,2L,1L,6L,1L,5L,3L };
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
public class A257461Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A257461.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A257461Inst : IEnumerable<long>
{
public static readonly long[] Value=A257461.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A257461.Bytes);
public long this[int i]=>Value[i];

public static A257461Inst Instance=new A257461Inst();

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