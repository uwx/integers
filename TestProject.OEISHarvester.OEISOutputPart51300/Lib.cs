using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using SuperOEISGenerator.IO;
namespace OEISReader.DatabaseX
{

public static class A058845
{
public static readonly long[] Value={ 1L,2L,49L,54L,172L,921L,1421L,12485L,78653L,1969457L,5606014L,90638394L };
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
public class A058845Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058845.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058845Inst : IEnumerable<long>
{
public static readonly long[] Value=A058845.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058845.Bytes);
public long this[int i]=>Value[i];

public static A058845Inst Instance=new A058845Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058846
{
public static readonly long[] Value={ 3L,5L,229L,257L,1031L,7213L,11863L,133853L,1002073L,31924583L,97137589L,1837875227L };
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
public class A058846Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058846.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058846Inst : IEnumerable<long>
{
public static readonly long[] Value=A058846.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058846.Bytes);
public long this[int i]=>Value[i];

public static A058846Inst Instance=new A058846Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058847
{
public static readonly long[] Value={ 3L,8L,5115L,6336L,81218L,3091903L,7843487L,792727297L,37706560773L,30398022089303L,263888373888362L,81120957675902118L };
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
public class A058847Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058847.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058847Inst : IEnumerable<long>
{
public static readonly long[] Value=A058847.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058847.Bytes);
public long this[int i]=>Value[i];

public static A058847Inst Instance=new A058847Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058848
{
public static readonly long[] Value={ 1L,12L,25L,61L,108L,211L,1344L,2339L,10539L,78409L,283181L,1748747L,1795423L,2386702L,2819089L,179101605L,1923088106L,2822581688L,7794689270L,17381011919L };
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
public class A058848Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058848.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058848Inst : IEnumerable<long>
{
public static readonly long[] Value=A058848.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058848.Bytes);
public long this[int i]=>Value[i];

public static A058848Inst Instance=new A058848Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058849
{
public static readonly long[] Value={ 9L,55L,99L,215L,357L,663L,3725L,6321L,26999L,191363L,675861L,4073533L,4180943L,5540147L,6531789L,400974175L,4248550291L,6224149881L,17109266357L,38023877981L };
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
public class A058849Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058849.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058849Inst : IEnumerable<long>
{
public static readonly long[] Value=A058849.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058849.Bytes);
public long this[int i]=>Value[i];

public static A058849Inst Instance=new A058849Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058850
{
public static readonly BigInteger[] Value={ 9L,404L,1441L,7227L,20802L,73337L,2576752L,7576757L,144666441L,7584554857L,96520502569L,3584243424853L,3776886886773L,6651010101566L,9260919190629L,36028948184982063L,4095836722276385904L,8806146443446416088L,BigInteger.Parse("66832347055074323866"),BigInteger.Parse("331143864040468341133") };
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
public class A058850Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058850.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058850Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058850.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058850.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058850Inst Instance=new A058850Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058851
{
public static readonly long[] Value={ 4L,18L,58L,134L,178L,424L,598L,1344L,4254L,5998L,57630L,58740L,59998L,127404L,424414L,425344L,599998L,1273554L,4244414L,5722840L,5999998L,18886848L,42683384L,57725768L,59999998L,424650414L,578107368L,588254658L,588349340L };
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
public class A058851Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058851.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058851Inst : IEnumerable<long>
{
public static readonly long[] Value=A058851.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058851.Bytes);
public long this[int i]=>Value[i];

public static A058851Inst Instance=new A058851Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058852
{
public static readonly long[] Value={ 0L,1L,9L,55L,99L,585L,595L,838L,999L,5995L,8668L,9999L,45954L,48384L,55755L,56665L,59895L,59995L,64846L,65656L,77977L,86968L,88488L,89398L,97479L,97579L,99099L,99199L,99999L,158851L,176671L,509905L,549945L,558855L,594495L,599995L,779977L };
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
public class A058852Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058852.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058852Inst : IEnumerable<long>
{
public static readonly long[] Value=A058852.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058852.Bytes);
public long this[int i]=>Value[i];

public static A058852Inst Instance=new A058852Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058853
{
public static readonly long[] Value={ 2L,3L,5L,7L,11L,13L,17L,19L,23L,29L,31L,37L,41L,43L,47L,53L,59L,61L,67L,71L,73L,79L,83L,89L,97L,101L,103L,107L,109L,113L,127L,131L,137L,139L,149L,151L,157L,163L,167L,179L,181L,191L,193L,197L,199L,211L,223L,227L,229L,233L,239L,241L,251L,257L,263L,269L,271L,277L };
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
public class A058853Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058853.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058853Inst : IEnumerable<long>
{
public static readonly long[] Value=A058853.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058853.Bytes);
public long this[int i]=>Value[i];

public static A058853Inst Instance=new A058853Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058854
{
public static readonly BigInteger[] Value={ 2L,5L,7L,173L,563L,73L,41L,369581L,1409L,109L,449L,176459L,44221L,12148537L,148381L,11399977L,5779337237L,16111L,26013917L,57405011L,3019L,1973L,191141L,6730949L,998917L,6619L,3853L,5153L,BigInteger.Parse("138961158000728258971"),2593L,6511107455627473L };
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
public class A058854Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058854.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058854Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058854.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058854.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058854Inst Instance=new A058854Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058855
{
public static readonly long[] Value={ 1L,1L,4L,8L,22L,52L,142L,362L,973L,2574L,6935L,18643L,50573L,137401L,375306L,1027898L,2825831L,7790055L,21539352L,59706865L,165921896L,462127857L,1289901083L,3607567539L,10108555623L,28374358327L,79777757405L,224653284863L };
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
public class A058855Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058855.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058855Inst : IEnumerable<long>
{
public static readonly long[] Value=A058855.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058855.Bytes);
public long this[int i]=>Value[i];

public static A058855Inst Instance=new A058855Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058856
{
public static readonly long[] Value={ 1L,3L,188L,378L,836L,10179L,15685L,36769L,53088L };
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
public class A058856Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058856.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058856Inst : IEnumerable<long>
{
public static readonly long[] Value=A058856.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058856.Bytes);
public long this[int i]=>Value[i];

public static A058856Inst Instance=new A058856Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058857
{
public static readonly long[] Value={ 0L,1L,3L,4L,9L,33L,52L,177L,1042L,2799L,5950L,8595L,19438L };
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
public class A058857Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058857.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058857Inst : IEnumerable<long>
{
public static readonly long[] Value=A058857.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058857.Bytes);
public long this[int i]=>Value[i];

public static A058857Inst Instance=new A058857Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058858
{
public static readonly long[] Value={ 1L,2L,8L,18L,42L,66L,69L,84L,1138L,1935L,3828L,9464L };
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
public class A058858Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058858.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058858Inst : IEnumerable<long>
{
public static readonly long[] Value=A058858.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058858.Bytes);
public long this[int i]=>Value[i];

public static A058858Inst Instance=new A058858Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058859
{
public static readonly long[] Value={ 1L,3L,19L,143L,1089L,8564L,69075L,569469L,4783377L,40829748L,353395155L,3096104105L,27415923905L,245069538465L,2209155012387L,20064713628389L,183478258249569L,1688112897834496L,15618577076864579L,145242456429736935L };
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
public class A058859Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058859.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058859Inst : IEnumerable<long>
{
public static readonly long[] Value=A058859.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058859.Bytes);
public long this[int i]=>Value[i];

public static A058859Inst Instance=new A058859Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058860
{
public static readonly long[] Value={ 1L,3L,19L,128L,909L,6737L,51683L,407802L,3293497L,27122967L,227095683L,1928656876L,16582719509L,144125955717L,1264625068163L,11190598332502L,99776445196977L,895685185070155L,8090065969366259L,73480719648381240L,670821169614526749L };
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
public class A058860Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058860.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058860Inst : IEnumerable<long>
{
public static readonly long[] Value=A058860.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058860.Bytes);
public long this[int i]=>Value[i];

public static A058860Inst Instance=new A058860Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058861
{
public static readonly long[] Value={ 0L,0L,1L,3L,12L,59L,313L,1713L,9559L,54189L,311460L,1812281L,10661303L,63336873L,379601353L,2293205687L,13953099573L,85451824382L,526431271347L,3260689089300L,20296848348929L,126918850161182L,796981464813540L };
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
public class A058861Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058861.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058861Inst : IEnumerable<long>
{
public static readonly long[] Value=A058861.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058861.Bytes);
public long this[int i]=>Value[i];

public static A058861Inst Instance=new A058861Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058862
{
public static readonly long[] Value={ 1L,2L,8L,61L,822L,18154L,617675L,30888596L,2192816760L,215488096587L,28791414081916L,5165908492061926L };
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
public class A058862Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058862.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058862Inst : IEnumerable<long>
{
public static readonly long[] Value=A058862.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058862.Bytes);
public long this[int i]=>Value[i];

public static A058862Inst Instance=new A058862Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058863
{
public static readonly BigInteger[] Value={ 1L,1L,4L,23L,181L,1812L,22037L,315569L,5201602L,97009833L,2019669961L,46432870222L,1168383075471L,31939474693297L,942565598033196L,29866348653695203L,1011335905644178273L,BigInteger.Parse("36446897413531401020"),BigInteger.Parse("1392821757824071815641"),BigInteger.Parse("56259101478392975833333") };
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
public class A058863Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058863.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058863Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058863.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058863.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058863Inst Instance=new A058863Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058864
{
public static readonly BigInteger[] Value={ 1L,2L,8L,49L,402L,4144L,51515L,750348L,12537204L,236424087L,4967735896L,115102258660L,2915655255385L,80164472149454L,2377679022913612L,75674858155603353L,2572626389524849478L,BigInteger.Parse("93040490884813025684") };
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
public class A058864Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058864.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058864Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058864.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058864.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058864Inst Instance=new A058864Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058865
{
public static readonly long[] Value={ 1L,0L,3L,1L,0L,0L,4L,12L,6L,1L,0L,0L,0L,5L,30L,75L,30L,30L,10L,1L,0L,0L,0L,0L,6L,60L,270L,360L,435L,270L,275L,80L,60L,15L,1L,0L,0L,0L,0L,0L,7L,105L,735L,1925L,2940L,3591L,4165L,2310L,2520L,1925L,882L,630L,175L,105L,21L,1L,0L,0L,0L,0L,0L,0L,8L,168L,1680L,7280L,16800L };
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
public class A058865Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058865.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058865Inst : IEnumerable<long>
{
public static readonly long[] Value=A058865.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058865.Bytes);
public long this[int i]=>Value[i];

public static A058865Inst Instance=new A058865Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058866
{
public static readonly long[] Value={ 1L,2L,6L,21L,83L,356L,1599L,7434L,35381L,171508L,843419L,4197179L,21094355L,106915928L,545859112L,2804656069L,14491370996L,75248398034L,392476363133L,2055245992376L,10801442696736L,56953957110855L,301207378815752L };
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
public class A058866Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058866.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058866Inst : IEnumerable<long>
{
public static readonly long[] Value=A058866.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058866.Bytes);
public long this[int i]=>Value[i];

public static A058866Inst Instance=new A058866Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058867
{
public static readonly long[] Value={ 5L,53L,211L,16787L,69623L,247141L,3565979L,4911311L,12012743L,23346809L,34346287L,36598607L,51042053L,383204683L,4470608101L,5007182863L,5558570491L,48287689717L,50284155289L,178796541817L,264860525507L,374787490919L,1521870804107L,2093308790851L,4228611064537L,6537587646671L,17432065861517L,22546768250359L,26923643849953L,187891466722913L };
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
public class A058867Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058867.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058867Inst : IEnumerable<long>
{
public static readonly long[] Value=A058867.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058867.Bytes);
public long this[int i]=>Value[i];

public static A058867Inst Instance=new A058867Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058868
{
public static readonly long[] Value={ 2L,6L,12L,24L,30L,42L,48L,60L,66L,72L,84L,90L,96L,144L,150L,156L,168L,186L,198L,204L,210L,228L,240L,258L,276L,300L,306L,348L,390L,420L };
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
public class A058868Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058868.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058868Inst : IEnumerable<long>
{
public static readonly long[] Value=A058868.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058868.Bytes);
public long this[int i]=>Value[i];

public static A058868Inst Instance=new A058868Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058869
{
public static readonly long[] Value={ 5L,53L,211L,20201L,16787L,69623L,255803L,247141L,3565979L,6314447L,4911311L };
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
public class A058869Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058869.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058869Inst : IEnumerable<long>
{
public static readonly long[] Value=A058869.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058869.Bytes);
public long this[int i]=>Value[i];

public static A058869Inst Instance=new A058869Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058870
{
public static readonly long[] Value={ 0L,1L,4L,18L,77L,346L,1578L,7396L,35297L,171352L,843067L,4196502L,21092793L,106912874L,545851964L,2804641873L,14491337393L,75248330560L,392476202012L,2055245665857L,10801441911431L,56953955507744L,301207374937558L };
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
public class A058870Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058870.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058870Inst : IEnumerable<long>
{
public static readonly long[] Value=A058870.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058870.Bytes);
public long this[int i]=>Value[i];

public static A058870Inst Instance=new A058870Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058871
{
public static readonly long[] Value={ 1L,3L,5L,7L,9L,13L,18L,20L,23L,25L,29L,48L,55L,98L,117L,119L,123L,130L,173L,187L,193L,198L,205L,213L,218L,223L,248L,249L,255L,259L,265L,268L,285L,292L,299L,311L,329L,346L,351L,386L,390L,393L,397L,411L,412L,448L,483L,487L,513L,515L,525L,554L,563L,574L,587L,597L };
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
public class A058871Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058871.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058871Inst : IEnumerable<long>
{
public static readonly long[] Value=A058871.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058871.Bytes);
public long this[int i]=>Value[i];

public static A058871Inst Instance=new A058871Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058872
{
public static readonly BigInteger[] Value={ 0L,2L,12L,80L,720L,9152L,165312L,4244480L,154732800L,8005686272L,587435092992L,61116916981760L,9011561121239040L,1882834327457349632L,BigInteger.Parse("557257804202631217152"),BigInteger.Parse("233610656002563147038720"),BigInteger.Parse("138681207656726645785559040"),BigInteger.Parse("116575238610106596799428165632") };
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
public class A058872Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058872.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058872Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058872.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058872.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058872Inst Instance=new A058872Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058873
{
public static readonly BigInteger[] Value={ 0L,0L,8L,192L,5120L,192000L,10938368L,976453632L,138258022400L,31176435302400L,11206367427166208L,6420240819994755072L,BigInteger.Parse("5860188449655027138560"),BigInteger.Parse("8518797083350691185950720"),BigInteger.Parse("19715227484913090464294371328"),BigInteger.Parse("72618853907514273117149186752512") };
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
public class A058873Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058873.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058873Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058873.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058873.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058873Inst Instance=new A058873Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058874
{
public static readonly BigInteger[] Value={ 0L,0L,0L,64L,5120L,450560L,56197120L,10877927424L,3407830056960L,1765179884830720L,1528596578057584640L,BigInteger.Parse("2225354662890778394624"),BigInteger.Parse("5460264388115266042593280"),BigInteger.Parse("22602991882128566753395998720"),BigInteger.Parse("157891665026904821204431467970560") };
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
public class A058874Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058874.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058874Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058874.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058874.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058874Inst Instance=new A058874Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058875
{
public static readonly long[] Value={ 1L,1L,1L,1L,6L,1L,1L,40L,24L,1L,1L,360L,640L,80L,1L,1L,4576L,24000L,7040L,240L,1L,1L,82656L,1367296L,878080L,62720L,672L,1L,1L,2122240L,122056704L,169967616L,23224320L,487424L,1792L,1L,1L,77366400L,17282252800L,53247344640L,13440516096L };
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
public class A058875Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058875.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058875Inst : IEnumerable<long>
{
public static readonly long[] Value=A058875.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058875.Bytes);
public long this[int i]=>Value[i];

public static A058875Inst Instance=new A058875Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058876
{
public static readonly long[] Value={ 1L,1L,2L,1L,9L,15L,1L,28L,198L,316L,1L,75L,1610L,10710L,16885L,1L,186L,10575L,211820L,1384335L,2174586L,1L,441L,61845L,3268125L,64144675L,416990763L,654313415L,1L,1016L,336924L,43832264L,2266772550L,44218682312L,286992935964L,450179768312L };
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
public class A058876Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058876.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058876Inst : IEnumerable<long>
{
public static readonly long[] Value=A058876.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058876.Bytes);
public long this[int i]=>Value[i];

public static A058876Inst Instance=new A058876Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058877
{
public static readonly long[] Value={ 0L,2L,9L,28L,75L,186L,441L,1016L,2295L,5110L,11253L,24564L,53235L,114674L,245745L,524272L,1114095L,2359278L,4980717L,10485740L,22020075L,46137322L,96468969L,201326568L,419430375L,872415206L,1811939301L,3758096356L,7784628195L,16106127330L,33285996513L };
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
public class A058877Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058877.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058877Inst : IEnumerable<long>
{
public static readonly long[] Value=A058877.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058877.Bytes);
public long this[int i]=>Value[i];

public static A058877Inst Instance=new A058877Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058878
{
public static readonly long[] Value={ 1L,1L,0L,1L,0L,0L,1L,0L,0L,1L,1L,0L,0L,4L,3L,0L,0L,1L,0L,0L,10L,15L,12L,15L,10L,0L,0L,1L,1L,0L,0L,20L,45L,72L,160L,240L,195L,120L,96L,60L,15L,0L,0L,0L,1L,0L,0L,35L,105L,252L,805L,1935L,3255L,4515L,5481L,5481L,4515L,3255L,1935L,805L,252L,105L,35L,0L,0L,1L,1L,0L,0L,56L };
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
public class A058878Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058878.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058878Inst : IEnumerable<long>
{
public static readonly long[] Value=A058878.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058878.Bytes);
public long this[int i]=>Value[i];

public static A058878Inst Instance=new A058878Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058879
{
public static readonly long[] Value={ 1L,1L,1L,1L,1L,3L,1L,1L,4L,7L,1L,1L,4L,9L,18L,1L,1L,5L,10L,28L,44L,1L,1L,5L,13L,32L,71L,117L,1L,1L,6L,14L,45L,89L,202L,299L,1L,1L,6L,17L,52L,130L,264L,542L,793L,1L,1L,7L,19L,69L,163L,413L,751L,1507L,2095L,1L,1L,7L,22L,79L,224L,544L,1221L,2179L,4114L,5607L };
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
public class A058879Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058879.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058879Inst : IEnumerable<long>
{
public static readonly long[] Value=A058879.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058879.Bytes);
public long this[int i]=>Value[i];

public static A058879Inst Instance=new A058879Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058880
{
public static readonly long[] Value={ 12L,36L,104L,352L,1172L,4119L,14572L,52492L,190652L,699266L,2581112L,9587602L,35791472L,134219859L,505290272L,1908881998L,7233629132L,27487817244L,104715393912L,399822505942L,1529755308212L,5864062368274L,22517998136936L };
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
public class A058880Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058880.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058880Inst : IEnumerable<long>
{
public static readonly long[] Value=A058880.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058880.Bytes);
public long this[int i]=>Value[i];

public static A058880Inst Instance=new A058880Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058881
{
public static readonly long[] Value={ 1L,1L,7L,137L };
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
public class A058881Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058881.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058881Inst : IEnumerable<long>
{
public static readonly long[] Value=A058881.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058881.Bytes);
public long this[int i]=>Value[i];

public static A058881Inst Instance=new A058881Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058882
{
public static readonly long[] Value={ 1L,1L,2L,5L,34L,2136L,7013488L };
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
public class A058882Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058882.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058882Inst : IEnumerable<long>
{
public static readonly long[] Value=A058882.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058882.Bytes);
public long this[int i]=>Value[i];

public static A058882Inst Instance=new A058882Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058883
{
public static readonly long[] Value={ 11L,67L,2L,4769L,67L };
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
public class A058883Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058883.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058883Inst : IEnumerable<long>
{
public static readonly long[] Value=A058883.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058883.Bytes);
public long this[int i]=>Value[i];

public static A058883Inst Instance=new A058883Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058884
{
public static readonly long[] Value={ -1L,0L,0L,1L,2L,5L,8L,15L,23L,37L,55L,83L,118L,171L,238L,332L,453L,618L,827L,1107L,1460L,1922L,2504L,3253L,4188L,5380L,6860L,8722L,11024L,13895L,17421L,21787L,27122L,33677L,41653L,51390L,63179L,77496L,94755L,115600L,140632L,170725L,206717L,249804L,301151L,362367L,435077L,521439L,623674L,744695L };
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
public class A058884Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058884.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058884Inst : IEnumerable<long>
{
public static readonly long[] Value=A058884.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058884.Bytes);
public long this[int i]=>Value[i];

public static A058884Inst Instance=new A058884Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058885
{
public static readonly long[] Value={ 0L,2L,4L,9L,12L,8L,20L,33L,159L,43L,49L,348L,60L,91L,8134L,1964L,1392L,735L,34060L,9030L,14052L,39306L,16906L,29338L,53711L,356449L,88137L,543041L,1435398L,1000154L,5037980L,2245246L,499245L,6240345L,2989574L,34190394L,11257817L,146038526L };
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
public class A058885Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058885.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058885Inst : IEnumerable<long>
{
public static readonly long[] Value=A058885.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058885.Bytes);
public long this[int i]=>Value[i];

public static A058885Inst Instance=new A058885Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058886
{
public static readonly long[] Value={ 2L,1L,2L,3L,4L,5L,5L,7L,9L,11L,12L,15L,18L,20L,23L,28L,33L,37L,42L,48L,56L,63L,70L,80L,92L,102L,114L,129L,145L,161L,178L,199L,223L,246L,271L,302L,335L,368L,404L,447L,493L,540L,591L,649L,713L,779L,848L,929L,1017L,1106L,1203L,1312L,1429L,1551L,1682L,1828L,1986L };
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
public class A058886Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058886.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058886Inst : IEnumerable<long>
{
public static readonly long[] Value=A058886.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058886.Bytes);
public long this[int i]=>Value[i];

public static A058886Inst Instance=new A058886Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058887
{
public static readonly long[] Value={ 3L,7L,17L,19L,19L,19L,31L,31L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L,47L };
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
public class A058887Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058887.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058887Inst : IEnumerable<long>
{
public static readonly long[] Value=A058887.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058887.Bytes);
public long this[int i]=>Value[i];

public static A058887Inst Instance=new A058887Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058888
{
public static readonly long[] Value={ 4L,4L,2L,0L,2L,0L,0L,0L,2L,2L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,2L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,2L,0L,2L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L,2L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,2L,0L,0L,2L,0L,0L,0L,0L,0L,0L,0L,0L };
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
public class A058888Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058888.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058888Inst : IEnumerable<long>
{
public static readonly long[] Value=A058888.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058888.Bytes);
public long this[int i]=>Value[i];

public static A058888Inst Instance=new A058888Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058889
{
public static readonly long[] Value={ 1L,2L,3L,3L,4L,4L,4L,5L,5L,6L,4L,4L,5L,5L,6L,6L,6L,5L,5L,6L,6L,7L,7L,7L,7L,8L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,5L,5L,6L,6L,7L,7L,7L,7L,8L,8L,8L,8L,8L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,6L,6L,7L,7L,8L,8L,8L,8L,9L,9L,9L,9L,9L,9L,10L,10L,10L,7L,7L,8L,8L,9L,9L,9L,9L,10L,10L,10L,10L,10L,10L,11L,11L,11L };
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
public class A058889Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058889.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058889Inst : IEnumerable<long>
{
public static readonly long[] Value=A058889.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058889.Bytes);
public long this[int i]=>Value[i];

public static A058889Inst Instance=new A058889Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058890
{
public static readonly long[] Value={ 0L,2L,9L,10L,15L,11L,14L,14L,15L,17L,22L,18L,26L,16L,21L,22L,34L,17L,38L,25L,23L,24L,46L,22L,35L,28L,33L,24L,58L,23L,62L,38L,31L,36L,29L,24L,74L,40L,35L,29L,82L,25L,86L,32L,27L,48L,94L,30L };
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
public class A058890Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058890.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058890Inst : IEnumerable<long>
{
public static readonly long[] Value=A058890.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058890.Bytes);
public long this[int i]=>Value[i];

public static A058890Inst Instance=new A058890Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058891
{
public static readonly BigInteger[] Value={ 1L,2L,8L,128L,32768L,2147483648L,9223372036854775808UL,BigInteger.Parse("170141183460469231731687303715884105728"),BigInteger.Parse("57896044618658097711785492504343953926634992332820282019728792003956564819968") };
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
public class A058891Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058891.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058891Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058891.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058891.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058891Inst Instance=new A058891Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058892
{
public static readonly BigInteger[] Value={ 1L,1L,5L,31L,265L,2621L,31621L,426595L,6574961L,111673945L,2092318021L,42552808871L,937495160185L,22150499622421L,559765402811525L,15039597200385451L,428293292251548001L,12875707199330296625UL,BigInteger.Parse("407547173842501629061") };
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
public class A058892Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058892.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058892Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058892.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058892.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058892Inst Instance=new A058892Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058893
{
public static readonly long[] Value={ 1L,5L,9L,22L,112L,118L,93L,899L,2346L,1773L,386L,5940L,27446L,48426L,28650L,1586L,35138L,247752L,745180L,995290L,484578L };
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
public class A058893Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058893.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058893Inst : IEnumerable<long>
{
public static readonly long[] Value=A058893.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058893.Bytes);
public long this[int i]=>Value[i];

public static A058893Inst Instance=new A058893Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058894
{
public static readonly long[] Value={ 1280073L,1280438L,1280441L,1281166L,1281191L,1281242L };
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
public class A058894Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058894.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058894Inst : IEnumerable<long>
{
public static readonly long[] Value=A058894.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058894.Bytes);
public long this[int i]=>Value[i];

public static A058894Inst Instance=new A058894Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058895
{
public static readonly long[] Value={ 0L,0L,14L,78L,252L,620L,1290L,2394L,4088L,6552L,9990L,14630L,20724L,28548L,38402L,50610L,65520L,83504L,104958L,130302L,159980L,194460L,234234L,279818L,331752L,390600L,456950L,531414L,614628L,707252L,809970L,923490L,1048544L,1185888L,1336302L,1500590L,1679580L };
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
public class A058895Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058895.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058895Inst : IEnumerable<long>
{
public static readonly long[] Value=A058895.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058895.Bytes);
public long this[int i]=>Value[i];

public static A058895Inst Instance=new A058895Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058896
{
public static readonly long[] Value={ -3L,0L,12L,60L,252L,1020L,4092L,16380L,65532L,262140L,1048572L,4194300L,16777212L,67108860L,268435452L,1073741820L,4294967292L,17179869180L,68719476732L,274877906940L,1099511627772L,4398046511100L,17592186044412L,70368744177660L,281474976710652L,1125899906842620L };
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
public class A058896Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058896.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058896Inst : IEnumerable<long>
{
public static readonly long[] Value=A058896.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058896.Bytes);
public long this[int i]=>Value[i];

public static A058896Inst Instance=new A058896Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058897
{
public static readonly long[] Value={ 6L,39L,78L,95L,82L,4L };
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
public class A058897Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058897.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058897Inst : IEnumerable<long>
{
public static readonly long[] Value=A058897.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058897.Bytes);
public long this[int i]=>Value[i];

public static A058897Inst Instance=new A058897Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058898
{
public static readonly long[] Value={ 13L,19L,25L,26L,35L,38L,47L,49L,50L,52L,55L,67L,70L,76L,94L,95L,97L,98L,100L,103L,104L,109L,110L,115L,117L,131L,134L,140L,151L,152L,157L,159L,171L,175L,179L,183L,185L,187L,188L,190L,193L,194L,196L,199L,200L,203L,206L,208L,217L,218L,220L,227L,229L };
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
public class A058898Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058898.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058898Inst : IEnumerable<long>
{
public static readonly long[] Value=A058898.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058898.Bytes);
public long this[int i]=>Value[i];

public static A058898Inst Instance=new A058898Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058899
{
public static readonly long[] Value={ 17L,32L,44L,51L,94L,95L,96L,106L,107L,112L,118L,132L,148L,153L,199L,224L,226L,232L,235L,236L,238L,256L,265L,268L,269L,274L,277L,281L,282L,284L,285L,288L,296L,308L,318L,321L,334L,336L,343L,352L,354L,368L,396L,442L,443L,444L,454L,459L,469L,472L };
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
public class A058899Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058899.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058899Inst : IEnumerable<long>
{
public static readonly long[] Value=A058899.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058899.Bytes);
public long this[int i]=>Value[i];

public static A058899Inst Instance=new A058899Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058900
{
public static readonly long[] Value={ 29L,41L,71L,83L,93L,111L,113L,114L,116L,117L,122L,123L,125L,135L,137L,143L,146L,153L,164L,167L,191L,197L,201L,237L,242L,263L,275L,279L,282L,284L,285L,291L,303L,305L,311L,323L,326L,327L,332L,359L,362L,369L,372L,375L,377L,382L,383L,389L,407L,410L };
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
public class A058900Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058900.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058900Inst : IEnumerable<long>
{
public static readonly long[] Value=A058900.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058900.Bytes);
public long this[int i]=>Value[i];

public static A058900Inst Instance=new A058900Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058901
{
public static readonly long[] Value={ 16L,22L,28L,46L,56L,58L,68L,74L,76L,80L,106L,108L,110L,118L,128L,136L,138L,140L,146L,152L,168L,198L,202L,206L,208L,230L,249L,256L,258L,262L,263L,268L,274L,276L,278L,280L,284L,286L,288L,290L,292L,294L,296L,298L,302L,318L,323L,324L,326L,336L,338L };
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
public class A058901Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058901.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058901Inst : IEnumerable<long>
{
public static readonly long[] Value=A058901.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058901.Bytes);
public long this[int i]=>Value[i];

public static A058901Inst Instance=new A058901Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058902
{
public static readonly long[] Value={ 27L,33L,64L,82L,97L,100L,103L,104L,107L,118L,122L,124L,125L,128L,134L,135L,152L,159L,162L,177L,190L,193L,195L,198L,205L,208L,212L,214L,232L,233L,250L,277L,280L,298L,334L,343L,345L,349L,352L,358L,362L,363L,364L,370L,380L,382L,384L,403L,427L,442L };
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
public class A058902Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058902.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058902Inst : IEnumerable<long>
{
public static readonly long[] Value=A058902.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058902.Bytes);
public long this[int i]=>Value[i];

public static A058902Inst Instance=new A058902Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058903
{
public static readonly long[] Value={ 30L,86L,102L,134L,138L,141L,158L,162L,167L,170L,183L,186L,194L,210L,213L,233L,284L,290L,306L,312L,314L,326L,330L,338L,354L,362L,366L,368L,428L,452L,480L,530L,534L,536L,540L,542L,554L,564L,578L,591L,602L,645L,648L,656L,705L,708L,714L,740L,746L };
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
public class A058903Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058903.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058903Inst : IEnumerable<long>
{
public static readonly long[] Value=A058903.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058903.Bytes);
public long this[int i]=>Value[i];

public static A058903Inst Instance=new A058903Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058904
{
public static readonly long[] Value={ 42L,44L,51L,52L,60L,105L,109L,116L,124L,173L,177L,178L,181L,201L,205L,209L,210L,213L,214L,217L,233L,237L,241L,242L,245L,249L,250L,251L,254L,255L,269L,273L,277L,278L,282L,285L,287L,290L,298L,299L,300L,308L,336L,343L,348L,352L,397L,401L,402L,403L };
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
public class A058904Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058904.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058904Inst : IEnumerable<long>
{
public static readonly long[] Value=A058904.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058904.Bytes);
public long this[int i]=>Value[i];

public static A058904Inst Instance=new A058904Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058905
{
public static readonly long[] Value={ 46L,47L,48L,56L,58L,66L,76L,86L,136L,138L,167L,176L,222L,227L,228L,248L,258L,298L,302L,308L,312L,316L,318L,338L,343L,344L,347L,348L,352L,354L,356L,358L,362L,374L,383L,384L,392L,398L,402L,403L,404L,406L,407L,408L,411L,412L,414L,416L,422L,423L };
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
public class A058905Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058905.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058905Inst : IEnumerable<long>
{
public static readonly long[] Value=A058905.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058905.Bytes);
public long this[int i]=>Value[i];

public static A058905Inst Instance=new A058905Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058906
{
public static readonly long[] Value={ 68L,70L,79L,80L,82L,92L,104L,200L,202L,212L,214L,224L,225L,248L,260L,314L,320L,332L,380L,392L,452L,458L,464L,490L,502L,508L,512L,513L,514L,518L,520L,524L,530L,562L,568L,574L,578L,579L,580L,584L,585L,590L,592L,595L,598L,599L,622L,628L,634L,635L };
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
public class A058906Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058906.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058906Inst : IEnumerable<long>
{
public static readonly long[] Value=A058906.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058906.Bytes);
public long this[int i]=>Value[i];

public static A058906Inst Instance=new A058906Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058907
{
public static readonly long[] Value={ 86L,87L,88L,90L,99L,101L,102L,112L,113L,114L,125L,126L,138L,229L,235L,244L,245L,246L,256L,258L,269L,270L,282L,307L,373L,379L,385L,391L,392L,400L,402L,426L,451L,464L,530L,535L,536L,542L,543L,547L,548L,607L,608L,620L,667L,673L,674L,679L,680L,685L };
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
public class A058907Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058907.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058907Inst : IEnumerable<long>
{
public static readonly long[] Value=A058907.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058907.Bytes);
public long this[int i]=>Value[i];

public static A058907Inst Instance=new A058907Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058908
{
public static readonly long[] Value={ 5077L,9876548287L,19753091497L,29629634707L,39506177917L,49382721127L };
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
public class A058908Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058908.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058908Inst : IEnumerable<long>
{
public static readonly long[] Value=A058908.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058908.Bytes);
public long this[int i]=>Value[i];

public static A058908Inst Instance=new A058908Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058909
{
public static readonly long[] Value={ 15618090L,22022490L,22816290L,22908090L,23294190L,23507490L,26679990L,27114690L,27687090L,28275690L,29447898L,29544690L,29582490L,29670378L,29910138L,30134238L,30426918L,31207890L,31406910L,31430670L,31490610L,32024670L,32035470L,32054910L };
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
public class A058909Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058909.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058909Inst : IEnumerable<long>
{
public static readonly long[] Value=A058909.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058909.Bytes);
public long this[int i]=>Value[i];

public static A058909Inst Instance=new A058909Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058910
{
public static readonly long[] Value={ 3L,5L,17L,257L,641L,1217L,14593L,167809L,671233L,1314497L,180449537L,424050817L };
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
public class A058910Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058910.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058910Inst : IEnumerable<long>
{
public static readonly long[] Value=A058910.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058910.Bytes);
public long this[int i]=>Value[i];

public static A058910Inst Instance=new A058910Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058911
{
public static readonly long[] Value={ 0L,1L,2L,3L,6L,9L,462L };
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
public class A058911Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058911.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058911Inst : IEnumerable<long>
{
public static readonly long[] Value=A058911.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058911.Bytes);
public long this[int i]=>Value[i];

public static A058911Inst Instance=new A058911Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058912
{
public static readonly long[] Value={ 2L,3L,19L,30L,535L,1551L };
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
public class A058912Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058912.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058912Inst : IEnumerable<long>
{
public static readonly long[] Value=A058912.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058912.Bytes);
public long this[int i]=>Value[i];

public static A058912Inst Instance=new A058912Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058913
{
public static readonly long[] Value={ 62L,2L,26L,13L,4L,157L,187L,64L,73L,1L,82L,19L,28L,46L,172L,37L,1702L,10234L,16687L };
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
public class A058913Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058913.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058913Inst : IEnumerable<long>
{
public static readonly long[] Value=A058913.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058913.Bytes);
public long this[int i]=>Value[i];

public static A058913Inst Instance=new A058913Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058914
{
public static readonly long[] Value={ 0L,2L,2L,1L,1L,1L,3L,2L,3L,1L,2L,4L,1L,1L,2L,3L,1L,2L,5L,1L,3L,2L,3L,1L,3L,1L,2L,3L,2L,1L,4L,1L,4L,2L,1L,1L,2L,2L,1L,2L,1L,1L,1L,5L,2L,1L,1L,1L,2L,1L,1L,2L,1L,2L,1L,1L,3L,1L,2L,2L,5L,1L,1L,2L,2L,2L,1L,3L,2L,1L,3L,1L,1L,2L,2L,1L,1L,6L,1L,1L,2L,9L,1L,2L,1L,1L,5L,4L,1L,36L,1L,1L,2L,15L,8L,1L,4L,4L,1L,1L,1L,4L,5L,1L };
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
public class A058914Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058914.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058914Inst : IEnumerable<long>
{
public static readonly long[] Value=A058914.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058914.Bytes);
public long this[int i]=>Value[i];

public static A058914Inst Instance=new A058914Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058915
{
public static readonly BigInteger[] Value={ 2L,7L,34L,181L,1266L,14106L,293756L,12362198L,1032671168L,166176421788L,50672459139597L,29105501987344357L,BigInteger.Parse("31455795559882541775"),BigInteger.Parse("64032588337815572241795"),BigInteger.Parse("246000022800939308314311897") };
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
public class A058915Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058915.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058915Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058915.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058915.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058915Inst Instance=new A058915Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058916
{
public static readonly long[] Value={ 1L,1L,4L,5L,2008L,153040L,20933840L,4662857360L,1579060246400L };
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
public class A058916Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058916.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058916Inst : IEnumerable<long>
{
public static readonly long[] Value=A058916.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058916.Bytes);
public long this[int i]=>Value[i];

public static A058916Inst Instance=new A058916Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058917
{
public static readonly long[] Value={ 1L,4L,6L,10L,14L,17L };
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
public class A058917Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058917.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058917Inst : IEnumerable<long>
{
public static readonly long[] Value=A058917.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058917.Bytes);
public long this[int i]=>Value[i];

public static A058917Inst Instance=new A058917Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058918
{
public static readonly long[] Value={ 1L,5L,7L,15L,19L,35L };
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
public class A058918Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058918.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058918Inst : IEnumerable<long>
{
public static readonly long[] Value=A058918.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058918.Bytes);
public long this[int i]=>Value[i];

public static A058918Inst Instance=new A058918Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058919
{
public static readonly long[] Value={ 1L,1L,5L,25L,85L,221L,481L,925L,1625L,2665L,4141L,6161L,8845L,12325L,16745L,22261L,29041L,37265L,47125L,58825L,72581L,88621L,107185L,128525L,152905L,180601L,211901L,247105L,286525L,330485L,379321L,433381L,493025L,558625L,630565L,709241L };
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
public class A058919Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058919.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058919Inst : IEnumerable<long>
{
public static readonly long[] Value=A058919.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058919.Bytes);
public long this[int i]=>Value[i];

public static A058919Inst Instance=new A058919Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058920
{
public static readonly long[] Value={ 1L,10L,65L,250L,697L,1586L,3145L,5650L,9425L,14842L,22321L,32330L,45385L,62050L,82937L,108706L,140065L,177770L,222625L,275482L,337241L,408850L,491305L,585650L,692977L,814426L,951185L,1104490L,1275625L,1465922L,1676761L,1909570L,2165825L };
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
public class A058920Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058920.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058920Inst : IEnumerable<long>
{
public static readonly long[] Value=A058920.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058920.Bytes);
public long this[int i]=>Value[i];

public static A058920Inst Instance=new A058920Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058921
{
public static readonly BigInteger[] Value={ 1L,0L,8L,739L,188278L,102375969L,101821432401L,167335039031665L,422730142353744596L,BigInteger.Parse("1555259421231289181129"),BigInteger.Parse("7990793301334594538543360"),BigInteger.Parse("55446117019635417854317742418"),BigInteger.Parse("505534592436277558571563209641430"),BigInteger.Parse("5920020716842325326522410002905164381") };
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
public class A058921Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058921.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058921Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058921.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058921.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058921Inst Instance=new A058921Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058922
{
public static readonly long[] Value={ 0L,4L,16L,48L,128L,320L,768L,1792L,4096L,9216L,20480L,45056L,98304L,212992L,458752L,983040L,2097152L,4456448L,9437184L,19922944L,41943040L,88080384L,184549376L,385875968L,805306368L,1677721600L,3489660928L,7247757312L };
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
public class A058922Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058922.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058922Inst : IEnumerable<long>
{
public static readonly long[] Value=A058922.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058922.Bytes);
public long this[int i]=>Value[i];

public static A058922Inst Instance=new A058922Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058923
{
public static readonly long[] Value={ 1L,1L,0L,-2L,-4L,-4L,1L,15L,43L,91L,166L,276L,430L,638L,911L,1261L,1701L,2245L,2908L,3706L,4656L,5776L,7085L,8603L,10351L,12351L,14626L,17200L,20098L,23346L,26971L,31001L,35465L,40393L,45816L,51766L,58276L,65380L,73113L,81511L,90611L,100451L,111070L,122508L };
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
public class A058923Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058923.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058923Inst : IEnumerable<long>
{
public static readonly long[] Value=A058923.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058923.Bytes);
public long this[int i]=>Value[i];

public static A058923Inst Instance=new A058923Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058924
{
public static readonly long[] Value={ 1L,4L,18L,176L,2150L,34092L,657188L,14906432L,389737818L,11529145100L };
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
public class A058924Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058924.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058924Inst : IEnumerable<long>
{
public static readonly long[] Value=A058924.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058924.Bytes);
public long this[int i]=>Value[i];

public static A058924Inst Instance=new A058924Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058925
{
public static readonly long[] Value={ 1L,2L,6L,44L,430L,5682L,93884L,1863304L,43304202L,1152914510L };
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
public class A058925Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058925.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058925Inst : IEnumerable<long>
{
public static readonly long[] Value=A058925.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058925.Bytes);
public long this[int i]=>Value[i];

public static A058925Inst Instance=new A058925Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058926
{
public static readonly long[] Value={ 1L,2L,4L,16L,78L,492L,3684L,32338L,324040L,3655904L };
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
public class A058926Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058926.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058926Inst : IEnumerable<long>
{
public static readonly long[] Value=A058926.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058926.Bytes);
public long this[int i]=>Value[i];

public static A058926Inst Instance=new A058926Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058927
{
public static readonly long[] Value={ 1L,1L,5L,49L,243L,14641L,371293L,253125L,410338673L,16983563041L,1400846643L,41426511213649L };
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
public class A058927Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058927.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058927Inst : IEnumerable<long>
{
public static readonly long[] Value=A058927.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058927.Bytes);
public long this[int i]=>Value[i];

public static A058927Inst Instance=new A058927Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058928
{
public static readonly long[] Value={ 1L,2L,8L,48L,128L,3840L,46080L,14336L,10321920L,185794560L,6553600L,81749606400L };
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
public class A058928Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058928.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058928Inst : IEnumerable<long>
{
public static readonly long[] Value=A058928.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058928.Bytes);
public long this[int i]=>Value[i];

public static A058928Inst Instance=new A058928Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058929
{
public static readonly BigInteger[] Value={ 0L,1L,60L,2520L,453600L,59875200L,10897286400L,6701831136000L,2623194782208000L,1338096104497152000L,BigInteger.Parse("1633313557551836160000"),BigInteger.Parse("1324107982344764897280000"),BigInteger.Parse("1408369399403068118016000000") };
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
public class A058929Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058929.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058929Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058929.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058929.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058929Inst Instance=new A058929Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058930
{
public static readonly BigInteger[] Value={ 0L,60L,19958400L,622452999168000L,BigInteger.Parse("258520167388849766400000"),BigInteger.Parse("675289572271869736778268672000000"),BigInteger.Parse("7393367369949286697176489031997849600000000") };
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
public class A058930Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058930.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058930Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058930.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058930.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058930Inst Instance=new A058930Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058931
{
public static readonly BigInteger[] Value={ 0L,1L,60L,0L,0L,19958400L,0L,0L,622452999168000L,0L,0L,BigInteger.Parse("258520167388849766400000"),0L,0L,BigInteger.Parse("675289572271869736778268672000000"),0L,0L,BigInteger.Parse("7393367369949286697176489031997849600000000"),0L,0L };
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
public class A058931Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058931.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058931Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058931.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058931.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058931Inst Instance=new A058931Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058932
{
public static readonly long[] Value={ 0L,0L,0L,0L,0L,0L,1L,1L,3L,5L,11L,20L };
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
public class A058932Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058932.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058932Inst : IEnumerable<long>
{
public static readonly long[] Value=A058932.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058932.Bytes);
public long this[int i]=>Value[i];

public static A058932Inst Instance=new A058932Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058933
{
public static readonly long[] Value={ 1L,1L,2L,1L,3L,2L,4L,1L,3L,4L,5L,2L,6L,5L,6L,1L,7L,3L,8L,4L,7L,8L,9L,2L,9L,10L,5L,6L,10L,7L,11L,1L,11L,12L,13L,3L,12L,14L,15L,4L,13L,8L,14L,9L,10L,16L,15L,2L,17L,11L,18L,12L,16L,5L,19L,6L,20L,21L,17L,7L,18L,22L,13L,1L,23L,14L,19L,15L,24L,16L,20L,3L,21L,25L,17L,18L,26L,19L,22L,4L,8L,27L,23L };
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
public class A058933Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058933.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058933Inst : IEnumerable<long>
{
public static readonly long[] Value=A058933.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058933.Bytes);
public long this[int i]=>Value[i];

public static A058933Inst Instance=new A058933Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058934
{
public static readonly long[] Value={ 0L,1L,3L,13L,45L,105L,159L,297L,1443L,2977L,3699L,11709L,12357L,43165L,121995L };
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
public class A058934Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058934.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058934Inst : IEnumerable<long>
{
public static readonly long[] Value=A058934.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058934.Bytes);
public long this[int i]=>Value[i];

public static A058934Inst Instance=new A058934Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058935
{
public static readonly BigInteger[] Value={ 0L,1L,110L,11011L,11011100L,11011100101L,11011100101110L,11011100101110111L,BigInteger.Parse("110111001011101111000"),BigInteger.Parse("1101110010111011110001001"),BigInteger.Parse("11011100101110111100010011010"),BigInteger.Parse("110111001011101111000100110101011"),BigInteger.Parse("1101110010111011110001001101010111100") };
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
public class A058935Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058935.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058935Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058935.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058935.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058935Inst Instance=new A058935Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058936
{
public static readonly long[] Value={ 0L,1L,3L,8L,3L,30L,20L,144L,90L,40L,840L,504L,420L,5760L,3360L,2688L,1260L };
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
public class A058936Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058936.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058936Inst : IEnumerable<long>
{
public static readonly long[] Value=A058936.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058936.Bytes);
public long this[int i]=>Value[i];

public static A058936Inst Instance=new A058936Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058937
{
public static readonly long[] Value={ 1L,0L,0L,0L,0L,1L,2L,3L,5L,7L,9L,12L,15L,18L,22L,26L,30L,35L,40L,45L,51L,57L,63L,70L,77L,84L,92L,100L,108L,117L,126L,135L,145L,155L,165L,176L,187L,198L,210L,222L,234L,247L,260L,273L,287L,301L,315L,330L,345L,360L,376L,392L,408L,425L,442L,459L,477L,495L,513L,532L,551L };
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
public class A058937Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058937.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058937Inst : IEnumerable<long>
{
public static readonly long[] Value=A058937.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058937.Bytes);
public long this[int i]=>Value[i];

public static A058937Inst Instance=new A058937Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058938
{
public static readonly long[] Value={ 1L,6L,8L,13L,20L,21L,34L,36L,48L,56L,63L,87L,89L,92L,94L,104L,106L,107L,111L,116L,117L,118L,120L,130L,132L,133L,141L,146L,147L,162L,170L,173L,179L,183L,185L,186L,198L,202L,203L,206L,215L,217L,219L,220L,225L,242L,248L,249L,258L,264L,265L,270L,271L,285L,290L,291L };
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
public class A058938Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058938.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058938Inst : IEnumerable<long>
{
public static readonly long[] Value=A058938.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058938.Bytes);
public long this[int i]=>Value[i];

public static A058938Inst Instance=new A058938Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058939
{
public static readonly BigInteger[] Value={ 0L,1L,140L,-1372000L,-268912000000L,1844736320000000000L,BigInteger.Parse("354336952345600000000000000"),BigInteger.Parse("-2041831254196285440000000000000000000"),BigInteger.Parse("-366048617485621006827520000000000000000000000000") };
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
public class A058939Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058939.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058939Inst : IEnumerable<BigInteger>
{
public static readonly BigInteger[] Value=A058939.Value;
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

public static Stream StreamLazy=>new EnumerableStream(A058939.Bytes);
public BigInteger this[int i]=>Value[i];

public static A058939Inst Instance=new A058939Inst();

public IEnumerator<BigInteger> GetEnumerator()
{
return (Value as IEnumerable<BigInteger>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058940
{
public static readonly long[] Value={ 1L,-1L,2L,0L,-1L,1L,1L,0L,-6L,4L,0L,1L,0L,-2L,1L,-1L,0L,5L,0L,-5L,2L,0L,-3L,0L,5L,0L,-3L,1L,17L,0L,-84L,0L,70L,0L,-28L,8L,0L,17L,0L,-28L,0L,14L,0L,-4L,1L,-31L,0L,153L,0L,-126L,0L,42L,0L,-9L,2L,0L,-155L,0L,255L,0L,-126L,0L,30L,0L,-5L,1L,691L,0L,-3410L,0L,2805L,0L,-924L,0L,165L,0L,-22L,4L,0L,2073L,0L,-3410L,0L,1683L,0L,-396L,0L,55L,0L,-6L };
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
public class A058940Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058940.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058940Inst : IEnumerable<long>
{
public static readonly long[] Value=A058940.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058940.Bytes);
public long this[int i]=>Value[i];

public static A058940Inst Instance=new A058940Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058941
{
public static readonly long[] Value={ 0L,2L,7L,35L,59L,84L,451L };
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
public class A058941Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058941.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058941Inst : IEnumerable<long>
{
public static readonly long[] Value=A058941.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058941.Bytes);
public long this[int i]=>Value[i];

public static A058941Inst Instance=new A058941Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058942
{
public static readonly long[] Value={ 1L,1L,1L,2L,4L,2L,8L,22L,20L,6L,56L,184L,224L,120L,24L,608L,2248L,3272L,2352L,840L,120L,9440L,38080L,62768L,54336L,26208L,6720L,720L,198272L,856480L,1550528L,1531344L,896064L,312480L,60480L,5040L,5410688L,24719488L,48207488L,52633344L,35371776L };
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
public class A058942Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058942.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058942Inst : IEnumerable<long>
{
public static readonly long[] Value=A058942.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058942.Bytes);
public long this[int i]=>Value[i];

public static A058942Inst Instance=new A058942Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058943
{
public static readonly long[] Value={ 10L,11L,111L,1011L,1101L,10011L,11001L,11111L,100101L,101001L,101111L,110111L,111011L,111101L,1000011L,1001001L,1010111L,1011011L,1100001L,1100111L,1101101L,1110011L,1110101L,10000011L,10001001L,10001111L,10010001L };
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
public class A058943Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058943.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058943Inst : IEnumerable<long>
{
public static readonly long[] Value=A058943.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058943.Bytes);
public long this[int i]=>Value[i];

public static A058943Inst Instance=new A058943Inst();

public IEnumerator<long> GetEnumerator()
{
return (Value as IEnumerable<long>).GetEnumerator();
}
IEnumerator IEnumerable.GetEnumerator()
{
return Value.GetEnumerator();
}
}

public static class A058944
{
public static readonly long[] Value={ 10L,11L,12L,101L,112L,122L,1021L,1022L,1102L,1112L,1121L,1201L,1211L,1222L,10012L,10022L,10102L,10111L,10121L,10202L,11002L,11021L,11101L,11111L,11122L,11222L,12002L,12011L,12101L,12112L,12121L,12212L,100021L,100022L,100112L,100211L };
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
public class A058944Enumerable : IEnumerable<byte[]>
{
public IEnumerator<byte[]> GetEnumerator()
{
foreach (var b in A058944.Bytes) {
yield return b;
}
}
IEnumerator IEnumerable.GetEnumerator()
{
return GetEnumerator();
}
}
public class A058944Inst : IEnumerable<long>
{
public static readonly long[] Value=A058944.Value;
public static Stream Stream
{
get
{
var ms=new MemoryStream();
// ReSharper disable once ForCanBeConvertedToForeach
for (var i=0; i < Value.Length; i++)
{
var b=BitConverter.GetBytes(Value[i]);
ms.Write(b,0,b.Length);
}
return ms;
}
}

public static Stream StreamLazy=>new EnumerableStream(A058944.Bytes);
public long this[int i]=>Value[i];

public static A058944Inst Instance=new A058944Inst();

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