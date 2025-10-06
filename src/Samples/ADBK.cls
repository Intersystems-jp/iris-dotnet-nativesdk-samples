Class Samples.ADBK Extends %Persistent
{

Property Name As %String;

Property Zipcode As %Integer;

Property Telno As %String;

Property Prefecture As %String;

Property City As %String;

Property Street As %String;

ClassMethod Init() As %Status
{
  Do ..%KillExtent()
  &SQL(insert into Samples.ADBK (Name,Zipcode,Telno,Prefecture,City,Street) values ('三井　重行',5300005,'06-222-7898','大阪府','大阪市','北区中之島2-2-2'))
  &SQL(insert into Samples.ADBK (Name,Zipcode,Telno,Prefecture,City,Street) values ('辰己　智子',0895600,'011-78-2345','北海道','十勝郡','河合町3-2'))
  &SQL(insert into Samples.ADBK (Name,Zipcode,Telno,Prefecture,City,Street) values ('石井　美香',5340000,'06-923-0415','大阪府','大阪市','都島区橘町5-20'))
  &SQL(insert into Samples.ADBK (Name,Zipcode,Telno,Prefecture,City,Street) values ('鏡　良子',6120000,'075-655-1256','京都府','京都市','伏見区上町4-7-6'))
  &SQL(insert into Samples.ADBK (Name,Zipcode,Telno,Prefecture,City,Street) values ('山田　猛',4650000,'052-544-9786','愛知県','名古屋市','東区中町1-10-10'))

  quit $$$OK
}

Storage Default
{
<Data name="ADBKDefaultData">
<Value name="1">
<Value>%%CLASSNAME</Value>
</Value>
<Value name="2">
<Value>Name</Value>
</Value>
<Value name="3">
<Value>Zipcode</Value>
</Value>
<Value name="4">
<Value>Telno</Value>
</Value>
<Value name="5">
<Value>Prefecture</Value>
</Value>
<Value name="6">
<Value>City</Value>
</Value>
<Value name="7">
<Value>Street</Value>
</Value>
</Data>
<DataLocation>^Samples.ADBKD</DataLocation>
<DefaultData>ADBKDefaultData</DefaultData>
<IdLocation>^Samples.ADBKD</IdLocation>
<IndexLocation>^Samples.ADBKI</IndexLocation>
<StreamLocation>^Samples.ADBKS</StreamLocation>
<Type>%Storage.Persistent</Type>
}

}
