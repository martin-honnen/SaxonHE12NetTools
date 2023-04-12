declare namespace cs = "http://nineml.com/ns/coffeesacks";

declare namespace output = "http://www.w3.org/2010/xslt-xquery-serialization";

declare option output:method 'xml';
declare option output:indent 'yes';

declare variable $grammar-uri as xs:string external := 'date2.ixml';

declare variable $input-date as xs:string external := '11 April 2023';

<invisible-xml-test>
{
let $parser := cs:load-grammar($grammar-uri)
return $parser($input-date)
}
</invisible-xml-test>