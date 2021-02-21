<a name='assembly'></a>
# Vsxmd

[[_TOC_]]

<a name='T-Vsxmd-Units-AssemblyUnit'></a>
## AssemblyUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Assembly unit.

<a name='M-Vsxmd-Units-AssemblyUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [AssemblyUnit](#T-Vsxmd-Units-AssemblyUnit 'Vsxmd.Units.AssemblyUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The assembly XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `assembly`. |

<a name='M-Vsxmd-Units-AssemblyUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Units-BaseUnit'></a>
## BaseUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

The base unit.

<a name='M-Vsxmd-Units-BaseUnit-#ctor-System-Xml-Linq-XElement,System-String-'></a>
### #ctor(element,elementName) `构造函数`

##### 概述

Initializes a new instance of the [BaseUnit](#T-Vsxmd-Units-BaseUnit 'Vsxmd.Units.BaseUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The XML element. |
| elementName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The expected XML element name. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML `element` name not matches the expected `elementName`. |

<a name='P-Vsxmd-Units-BaseUnit-Element'></a>
### Element `属性`

##### 概述

Gets the XML element.

<a name='P-Vsxmd-Units-BaseUnit-ElementContent'></a>
### ElementContent `属性`

##### 概述

Gets the Markdown content representing the element.

<a name='M-Vsxmd-Units-BaseUnit-GetAttribute-System-Xml-Linq-XName-'></a>
### GetAttribute(name) `方法`

##### 概述

Returns the [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') value of this [XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') that has the specified `name`.

##### 返回值

An [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') value that has the specified `name`; `null` if there is no attribute with the specified `name`.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') of the [XAttribute](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XAttribute 'System.Xml.Linq.XAttribute') to get. |

<a name='M-Vsxmd-Units-BaseUnit-GetChild-System-Xml-Linq-XName-'></a>
### GetChild(name) `方法`

##### 概述

Gets the first (in document order) child element with the specified `name`.

##### 返回值

A [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') that matches the specified `name`, or `null`.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') to match. |

<a name='M-Vsxmd-Units-BaseUnit-GetChildren-System-Xml-Linq-XName-'></a>
### GetChildren(name) `方法`

##### 概述

Returns a collection of the child elements of this element or document, in document order.
Only elements that have a matching [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') are included in the collection.

##### 返回值

An [IEnumerable`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable`1 'System.Collections.Generic.IEnumerable`1') of [XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') containing the children that have a matching [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName'), in document order.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| name | [System.Xml.Linq.XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') | The [XName](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XName 'System.Xml.Linq.XName') to match. |

<a name='M-Vsxmd-Units-BaseUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Converter'></a>
## Converter `类型`

##### 命名空间

Vsxmd

##### 概要

*从父继承.*

<a name='M-Vsxmd-Converter-#ctor-System-Xml-Linq-XDocument-'></a>
### #ctor(document) `构造函数`

##### 概述

Initializes a new instance of the [Converter](#T-Vsxmd-Converter 'Vsxmd.Converter') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| document | [System.Xml.Linq.XDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XDocument 'System.Xml.Linq.XDocument') | The XML document. |

<a name='M-Vsxmd-Converter-ToMarkdown-System-Xml-Linq-XDocument-'></a>
### ToMarkdown(document) `方法`

##### 概述

Convert VS XML document to Markdown syntax.

##### 返回值

The generated Markdown content.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| document | [System.Xml.Linq.XDocument](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XDocument 'System.Xml.Linq.XDocument') | The XML document. |

<a name='M-Vsxmd-Converter-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-EnumHelper'></a>
## EnumHelper `类型`

##### 命名空间

Vsxmd

##### 概述

Helper to Enum.

<a name='M-Vsxmd-EnumHelper-GetDescription-System-Enum-'></a>
### GetDescription(e) `方法`

##### 概述

Get Description Attribute Value.

##### 返回值

Description.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| e | [System.Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum') | enum value |

<a name='T-Vsxmd-Units-ExampleUnit'></a>
## ExampleUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Example unit.

<a name='M-Vsxmd-Units-ExampleUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [ExampleUnit](#T-Vsxmd-Units-ExampleUnit 'Vsxmd.Units.ExampleUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The example XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `example`. |

<a name='M-Vsxmd-Units-ExampleUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-ExampleUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>
### ToMarkdown(element) `方法`

##### 概述

Convert the example XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The example XML element. |

<a name='T-Vsxmd-Units-ExceptionUnit'></a>
## ExceptionUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Exception unit.

<a name='M-Vsxmd-Units-ExceptionUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [ExceptionUnit](#T-Vsxmd-Units-ExceptionUnit 'Vsxmd.Units.ExceptionUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The exception XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `exception`. |

<a name='M-Vsxmd-Units-ExceptionUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-ExceptionUnit-ToMarkdown-System-Collections-Generic-IEnumerable{System-Xml-Linq-XElement}-'></a>
### ToMarkdown(elements) `方法`

##### 概述

Convert the exception XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The exception XML element list. |

<a name='T-Vsxmd-Units-Extensions'></a>
## Extensions `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Extensions helper.

<a name='M-Vsxmd-Units-Extensions-AsCode-System-String-'></a>
### AsCode(code) `方法`

##### 概述

Wrap the `code` into Markdown backtick safely.

The backtick characters inside the `code` reverse as it is.

##### 返回值

The Markdown code span.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| code | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The code span. |

##### 备注

Reference: http://meta.stackexchange.com/questions/55437/how-can-the-backtick-character-be-included-in-code .

<a name='M-Vsxmd-Units-Extensions-Escape-System-String,System-Collections-Generic-IEnumerable{System-String}-'></a>
### Escape(content,typeparamNames) `方法`

##### 概述

Escape the content to keep it raw in Markdown syntax.

##### 返回值

The escaped content.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content. |
| typeparamNames | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The param names. |

<a name='M-Vsxmd-Units-Extensions-Join-System-Collections-Generic-IEnumerable{System-String},System-String-'></a>
### Join(value,separator) `方法`

##### 概述

Concatenates the `value`s with the `separator`.

##### 返回值

The concatenated string.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| value | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The string values. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The separator. |

<a name='M-Vsxmd-Units-Extensions-NthLast``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### NthLast&lt;TSource&gt;(source,index) `方法`

##### 概述

Gets the n-th last element from the `source`.

##### 返回值

The element at the specified position in the `source` sequence.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{``0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source enumerable. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index for the n-th last. |

##### 泛型

| 名称 | 描述 |
| ---- | ----------- |
| TSource | The type of the elements of `source`. |

<a name='M-Vsxmd-Units-Extensions-Suffix-System-String,System-String-'></a>
### Suffix(value,suffix) `方法`

##### 概述

Suffix the `suffix` to the `value`, and generate a new string.

##### 返回值

The new string.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The original string value. |
| suffix | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The suffix string. |

<a name='M-Vsxmd-Units-Extensions-TakeAllButLast``1-System-Collections-Generic-IEnumerable{``0},System-Int32-'></a>
### TakeAllButLast&lt;TSource&gt;(source,count) `方法`

##### 概述

Take all element except the last `count`.

##### 返回值

The generated enumerable.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| source | [System.Collections.Generic.IEnumerable{``0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{``0}') | The source enumerable. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The number to except. |

##### 泛型

| 名称 | 描述 |
| ---- | ----------- |
| TSource | The type of the elements of `source`. |

<a name='M-Vsxmd-Units-Extensions-ToAnchor-System-String-'></a>
### ToAnchor(href) `方法`

##### 概述

Generate an anchor for the `href`.

##### 返回值

The anchor for the `href`.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| href | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The href. |

<a name='M-Vsxmd-Units-Extensions-ToHereLink-System-String-'></a>
### ToHereLink(href) `方法`

##### 概述

Generate "to here" link for the `href`.

##### 返回值

The "to here" link for the `href`.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| href | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The href. |

<a name='M-Vsxmd-Units-Extensions-ToLowerString-Vsxmd-Units-MemberKind-'></a>
### ToLowerString(memberKind) `方法`

##### 概述

Convert the [MemberKind](#T-Vsxmd-Units-MemberKind 'Vsxmd.Units.MemberKind') to its lowercase name.

##### 返回值

The member kind's lowercase name.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| memberKind | [Vsxmd.Units.MemberKind](#T-Vsxmd-Units-MemberKind 'Vsxmd.Units.MemberKind') | The member kind. |

<a name='M-Vsxmd-Units-Extensions-ToMarkdownText-System-Xml-Linq-XElement-'></a>
### ToMarkdownText(element) `方法`

##### 概述

Convert the inline XML nodes to Markdown text.
For example, it works for `summary` and `returns` elements.

##### 返回值

The generated Markdown content.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The XML element. |

##### 例子

This method converts the following `summary` element.

```
<summary>The <paramref name="element" /> value is <value>null</value>, it throws <c>ArgumentException</c>. For more, see <see cref="M:Vsxmd.Units.Extensions.ToMarkdownText(System.Xml.Linq.XElement)" />.</summary>
```

To the below Markdown content.

```
The `element` value is `null`, it throws `ArgumentException`. For more, see `ToMarkdownText`.
```

<a name='M-Vsxmd-Units-Extensions-ToReferenceLink-System-String,System-Boolean-'></a>
### ToReferenceLink(memberName,useShortName) `方法`

##### 概述

Generate the reference link for the `memberName`.

##### 返回值

The generated reference link.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| memberName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The member name. |
| useShortName | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicate if use short type name. |

##### 例子

For `T:Vsxmd.Units.MemberUnit`, convert it to `[MemberUnit](#T-Vsxmd.Units.MemberUnit)`.

For `T:System.ArgumentException`, convert it to `[ArgumentException](http://msdn/path/to/System.ArgumentException)`.

<a name='T-Vsxmd-IConverter'></a>
## IConverter `类型`

##### 命名空间

Vsxmd

##### 概述

Converter for XML document to Markdown syntax conversion.

<a name='M-Vsxmd-IConverter-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概述

Convert to Markdown syntax.

##### 返回值

The generated Markdown content.

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Units-IUnit'></a>
## IUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

[IUnit](#T-Vsxmd-Units-IUnit 'Vsxmd.Units.IUnit') is wrapper to handle XML elements.

<a name='M-Vsxmd-Units-IUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概述

Represent the XML element content as Markdown syntax.

##### 返回值

The generated Markdown content.

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Units-MemberKind'></a>
## MemberKind `类型`

##### 命名空间

Vsxmd.Units

##### 概述

The member kind.

<a name='F-Vsxmd-Units-MemberKind-Constants'></a>
### Constants `常量`

##### 概述

Constants

<a name='F-Vsxmd-Units-MemberKind-Constructor'></a>
### Constructor `常量`

##### 概述

Constructor.

<a name='F-Vsxmd-Units-MemberKind-Method'></a>
### Method `常量`

##### 概述

Method.

<a name='F-Vsxmd-Units-MemberKind-NotSupported'></a>
### NotSupported `常量`

##### 概述

Not supported member kind.

<a name='F-Vsxmd-Units-MemberKind-Property'></a>
### Property `常量`

##### 概述

Property.

<a name='F-Vsxmd-Units-MemberKind-Type'></a>
### Type `常量`

##### 概述

Type.

<a name='T-Vsxmd-Units-MemberName'></a>
## MemberName `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Member name.

<a name='M-Vsxmd-Units-MemberName-#ctor-System-String,System-Collections-Generic-IEnumerable{System-String},System-Collections-Generic-IEnumerable{System-String}-'></a>
### #ctor(name,paramNames) `构造函数`

##### 概述

Initializes a new instance of the [MemberName](#T-Vsxmd-Units-MemberName 'Vsxmd.Units.MemberName') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw member name. For example, `T:Vsxmd.Units.MemberName`. |
| paramNames | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The parameter names. It is only used when member kind is [Constructor](#F-Vsxmd-Units-MemberKind-Constructor 'Vsxmd.Units.MemberKind.Constructor') or [Method](#F-Vsxmd-Units-MemberKind-Method 'Vsxmd.Units.MemberKind.Method'). |

<a name='M-Vsxmd-Units-MemberName-#ctor-System-String-'></a>
### #ctor(name) `构造函数`

##### 概述

Initializes a new instance of the [MemberName](#T-Vsxmd-Units-MemberName 'Vsxmd.Units.MemberName') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The raw member name. For example, `T:Vsxmd.Units.MemberName`. |

<a name='P-Vsxmd-Units-MemberName-Caption'></a>
### Caption `属性`

##### 概述

Gets the caption representation for this member name.

##### 例子

For [Type](#F-Vsxmd-Units-MemberKind-Type 'Vsxmd.Units.MemberKind.Type'), show as `## Vsxmd.Units.MemberName [#](#here) [^](#contents)`.

For other kinds, show as `### Vsxmd.Units.MemberName.Caption [#](#here) [^](#contents)`.

<a name='P-Vsxmd-Units-MemberName-Kind'></a>
### Kind `属性`

##### 概述

Gets the member kind, one of [MemberKind](#T-Vsxmd-Units-MemberKind 'Vsxmd.Units.MemberKind').

<a name='P-Vsxmd-Units-MemberName-Link'></a>
### Link `属性`

##### 概述

Gets the link pointing to this member unit.

<a name='P-Vsxmd-Units-MemberName-Namespace'></a>
### Namespace `属性`

##### 概述

Gets the namespace name.

##### 例子

`System`, `Vsxmd`, `Vsxmd.Units`.

<a name='P-Vsxmd-Units-MemberName-TypeName'></a>
### TypeName `属性`

##### 概述

Gets the type name.

##### 例子

`Vsxmd.Program`, `Vsxmd.Units.TypeUnit`.

<a name='M-Vsxmd-Units-MemberName-CompareTo-Vsxmd-Units-MemberName-'></a>
### CompareTo() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-MemberName-GetParamTypes'></a>
### GetParamTypes() `方法`

##### 概述

Gets the method parameter type names from the member name.

##### 返回值

The method parameter type name list.

##### 参数

此 方法 没有参数.

##### 例子

It will prepend the type kind character (`T:`) to the type string.

For `(System.String,System.Int32)`, returns `["T:System.String","T:System.Int32"]`.

It also handle generic type.

For `(System.Collections.Generic.IEnumerable{System.String})`, returns `["T:System.Collections.Generic.IEnumerable{System.String}"]`.

<a name='M-Vsxmd-Units-MemberName-ToReferenceLink-System-Boolean-'></a>
### ToReferenceLink(useShortName) `方法`

##### 概述

Convert the member name to Markdown reference link.

If then name is under `System` namespace, the link points to MSDN.

Otherwise, the link points to this page anchor.

##### 返回值

The generated Markdown reference link.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| useShortName | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Indicate if use short type name. |

<a name='T-Vsxmd-Units-MemberUnit'></a>
## MemberUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Member unit.

<a name='M-Vsxmd-Units-MemberUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [MemberUnit](#T-Vsxmd-Units-MemberUnit 'Vsxmd.Units.MemberUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The member XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `member`. |

<a name='P-Vsxmd-Units-MemberUnit-Comparer'></a>
### Comparer `属性`

##### 概述

Gets the member unit comparer.

<a name='P-Vsxmd-Units-MemberUnit-Kind'></a>
### Kind `属性`

##### 概述

Gets the member kind, one of [MemberKind](#T-Vsxmd-Units-MemberKind 'Vsxmd.Units.MemberKind').

<a name='P-Vsxmd-Units-MemberUnit-Link'></a>
### Link `属性`

##### 概述

Gets the link pointing to this member unit.

<a name='P-Vsxmd-Units-MemberUnit-TypeName'></a>
### TypeName `属性`

##### 概述

Gets the type name.

##### 例子

`Vsxmd.Program`, `Vsxmd.Units.TypeUnit`.

<a name='M-Vsxmd-Units-MemberUnit-ComplementType-System-Collections-Generic-IEnumerable{Vsxmd-Units-MemberUnit}-'></a>
### ComplementType(group) `方法`

##### 概述

Complement a type unit if the member unit `group` does not have one.
One member unit group has the same [TypeName](#P-Vsxmd-Units-MemberUnit-TypeName 'Vsxmd.Units.MemberUnit.TypeName').

##### 返回值

The complemented member unit group.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| group | [System.Collections.Generic.IEnumerable{Vsxmd.Units.MemberUnit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{Vsxmd.Units.MemberUnit}') | The member unit group. |

<a name='M-Vsxmd-Units-MemberUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Units-MemberUnit-MemberUnitComparer'></a>
## MemberUnitComparer `类型`

##### 命名空间

Vsxmd.Units.MemberUnit

<a name='M-Vsxmd-Units-MemberUnit-MemberUnitComparer-Compare-Vsxmd-Units-MemberUnit,Vsxmd-Units-MemberUnit-'></a>
### Compare() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Units-ParamUnit'></a>
## ParamUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Param unit.

<a name='M-Vsxmd-Units-ParamUnit-#ctor-System-Xml-Linq-XElement,System-String-'></a>
### #ctor(element,paramType) `构造函数`

##### 概述

Initializes a new instance of the [ParamUnit](#T-Vsxmd-Units-ParamUnit 'Vsxmd.Units.ParamUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The param XML element. |
| paramType | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The parameter type corresponding to the param XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `param`. |

<a name='M-Vsxmd-Units-ParamUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-ParamUnit-ToMarkdown-System-Collections-Generic-IEnumerable{System-Xml-Linq-XElement},System-Collections-Generic-IEnumerable{System-String},Vsxmd-Units-MemberKind-'></a>
### ToMarkdown(elements,paramTypes,memberKind) `方法`

##### 概述

Convert the param XML element to Markdown safely.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The param XML element list. |
| paramTypes | [System.Collections.Generic.IEnumerable{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.String}') | The paramater type names. |
| memberKind | [Vsxmd.Units.MemberKind](#T-Vsxmd-Units-MemberKind 'Vsxmd.Units.MemberKind') | The member kind of the parent element. |

##### 备注

When the parameter (a.k.a `elements`) list is empty:

If parent element kind is [Constructor](#F-Vsxmd-Units-MemberKind-Constructor 'Vsxmd.Units.MemberKind.Constructor') or [Method](#F-Vsxmd-Units-MemberKind-Method 'Vsxmd.Units.MemberKind.Method'), it returns a hint about "no parameters".

If parent element kind is not the value mentioned above, it returns an empty string.

<a name='T-Vsxmd-Units-PermissionUnit'></a>
## PermissionUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Permission unit.

<a name='M-Vsxmd-Units-PermissionUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [PermissionUnit](#T-Vsxmd-Units-PermissionUnit 'Vsxmd.Units.PermissionUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The permission XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `permission`. |

<a name='M-Vsxmd-Units-PermissionUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-PermissionUnit-ToMarkdown-System-Collections-Generic-IEnumerable{System-Xml-Linq-XElement}-'></a>
### ToMarkdown(elements) `方法`

##### 概述

Convert the permission XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The permission XML element list. |

<a name='T-Vsxmd-Program'></a>
## Program `类型`

##### 命名空间

Vsxmd

##### 概述

Program entry.

##### 备注

Usage syntax:

```
Vsxmd.exe &lt;input-XML-path&gt; [output-Markdown-path]
```

The `input-XML-path` argument is required. It references to the VS generated XML documentation file.

The `output-Markdown-path` argument is optional. It indicates the file path for the Markdown output file. When not specific, it will be a `.md` file with same file name as the XML documentation file, path at the XML documentation folder.

<a name='M-Vsxmd-Program-Main-System-String[]-'></a>
### Main(args) `方法`

##### 概述

Program main function entry.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Program arguments. |

##### 另请参阅

- [Vsxmd.Program](#T-Vsxmd-Program 'Vsxmd.Program')

<a name='T-Vsxmd-Units-RemarksUnit'></a>
## RemarksUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Remarks unit.

<a name='M-Vsxmd-Units-RemarksUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [RemarksUnit](#T-Vsxmd-Units-RemarksUnit 'Vsxmd.Units.RemarksUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The remarks XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `remarks`. |

<a name='M-Vsxmd-Units-RemarksUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-RemarksUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>
### ToMarkdown(element) `方法`

##### 概述

Convert the remarks XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The remarks XML element. |

<a name='T-Vsxmd-Units-ReturnsUnit'></a>
## ReturnsUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Returns unit.

<a name='M-Vsxmd-Units-ReturnsUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [ReturnsUnit](#T-Vsxmd-Units-ReturnsUnit 'Vsxmd.Units.ReturnsUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The returns XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `returns`. |

<a name='M-Vsxmd-Units-ReturnsUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-ReturnsUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>
### ToMarkdown(element) `方法`

##### 概述

Convert the returns XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The returns XML element. |

<a name='T-Vsxmd-Units-SeealsoUnit'></a>
## SeealsoUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Seealso unit.

<a name='M-Vsxmd-Units-SeealsoUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [SeealsoUnit](#T-Vsxmd-Units-SeealsoUnit 'Vsxmd.Units.SeealsoUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The seealso XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `seealso`. |

<a name='M-Vsxmd-Units-SeealsoUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-SeealsoUnit-ToMarkdown-System-Collections-Generic-IEnumerable{System-Xml-Linq-XElement}-'></a>
### ToMarkdown(elements) `方法`

##### 概述

Convert the seealso XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The seealso XML element list. |

<a name='T-Vsxmd-Units-SummaryUnit'></a>
## SummaryUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Summary unit.

<a name='M-Vsxmd-Units-SummaryUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [SummaryUnit](#T-Vsxmd-Units-SummaryUnit 'Vsxmd.Units.SummaryUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The summary XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `summary`. |

<a name='M-Vsxmd-Units-SummaryUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-SummaryUnit-ToMarkdown-System-Xml-Linq-XElement-'></a>
### ToMarkdown(element) `方法`

##### 概述

Convert the summary XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The summary XML element. |

<a name='T-Vsxmd-TableOfContents'></a>
## TableOfContents `类型`

##### 命名空间

Vsxmd

##### 概述

Table of contents.

<a name='M-Vsxmd-TableOfContents-#ctor-System-Linq-IOrderedEnumerable{Vsxmd-Units-MemberUnit}-'></a>
### #ctor(memberUnits) `构造函数`

##### 概述

Initializes a new instance of the [TableOfContents](#T-Vsxmd-TableOfContents 'Vsxmd.TableOfContents') class.

It convert the table of contents from the `memberUnits`.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| memberUnits | [System.Linq.IOrderedEnumerable{Vsxmd.Units.MemberUnit}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.IOrderedEnumerable 'System.Linq.IOrderedEnumerable{Vsxmd.Units.MemberUnit}') | The member unit list. |

<a name='P-Vsxmd-TableOfContents-Link'></a>
### Link `属性`

##### 概述

Gets the link pointing to the table of contents.

<a name='M-Vsxmd-TableOfContents-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概述

Convert the table of contents to Markdown syntax.

##### 返回值

The table of contents in Markdown syntax.

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Program-Test'></a>
## Test `类型`

##### 命名空间

Vsxmd.Program

<a name='M-Vsxmd-Program-Test-#ctor'></a>
### #ctor() `构造函数`

##### 概述

Initializes a new instance of the [Test](#T-Vsxmd-Program-Test 'Vsxmd.Program.Test') class.

Test constructor without parameters.

See [Test.#ctor](#M-Vsxmd-Program-Test-#ctor 'Vsxmd.Program.Test.#ctor').

##### 参数

此 构造函数 没有参数.

##### 权限

| 名称 | 描述 |
| ---- | ----------- |
| [Vsxmd.Program](#T-Vsxmd-Program 'Vsxmd.Program') | Just for test. |

<a name='M-Vsxmd-Program-Test-TestBacktickInSummary'></a>
### TestBacktickInSummary() `方法`

##### 概述

Test backtick characters in summary comment.

See `should not inside code block`.

See `` `backtick inside code block` ``.

See ``code block inside backtick``.

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Program-Test-TestGenericException'></a>
### TestGenericException() `方法`

##### 概述

Test generic exception type.

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [Vsxmd.Program.Test.TestGenericParameter``2](#M-Vsxmd-Program-Test-TestGenericParameter``2-System-Linq-Expressions-Expression{System-Func{``0,``1,System-String}}- 'Vsxmd.Program.Test.TestGenericParameter``2(System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}})') | Just for test. |

<a name='M-Vsxmd-Program-Test-TestGenericParameter``2-System-Linq-Expressions-Expression{System-Func{``0,``1,System-String}}-'></a>
### TestGenericParameter&lt;T1, T2&gt;(expression) `方法`

##### 概述

Test generic parameter type.

See `T1` and `T2`.

##### 返回值

Nothing.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| expression | [System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Linq.Expressions.Expression 'System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}}') | The linq expression. |

##### 泛型

| 名称 | 描述 |
| ---- | ----------- |
| T1 | Generic type 1. |
| T2 | Generic type 2. |

<a name='M-Vsxmd-Program-Test-TestGenericPermission'></a>
### TestGenericPermission() `方法`

##### 概述

Test generic exception type.

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

##### 权限

| 名称 | 描述 |
| ---- | ----------- |
| [Vsxmd.Program.Test.TestGenericParameter``2](#M-Vsxmd-Program-Test-TestGenericParameter``2-System-Linq-Expressions-Expression{System-Func{``0,``1,System-String}}- 'Vsxmd.Program.Test.TestGenericParameter``2(System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}})') | Just for test. |

<a name='M-Vsxmd-Program-Test-TestGenericReference'></a>
### TestGenericReference() `方法`

##### 概述

Test generic reference type.

See [TestGenericParameter``2](#M-Vsxmd-Program-Test-TestGenericParameter``2-System-Linq-Expressions-Expression{System-Func{``0,``1,System-String}}- 'Vsxmd.Program.Test.TestGenericParameter``2(System.Linq.Expressions.Expression{System.Func{``0,``1,System.String}})').

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Program-Test-TestParamWithoutDescription-System-String-'></a>
### TestParamWithoutDescription(p) `方法`

##### 概述

Test a param tag without description.

##### 返回值

Nothing.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| p | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Vsxmd-Program-Test-TestSeeLangword'></a>
### TestSeeLangword() `方法`

##### 概述

Test see tag with langword attribute. See `true`.

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Program-Test-TestSpaceAfterInlineElements``1-System-Boolean-'></a>
### TestSpaceAfterInlineElements&lt;&gt;() `方法`

##### 概述

Test space after inline elements.

See `code block` should follow a space.

See a value at the end of a `sentence`.

See [TestSpaceAfterInlineElements``1](#M-Vsxmd-Program-Test-TestSpaceAfterInlineElements``1-System-Boolean- 'Vsxmd.Program.Test.TestSpaceAfterInlineElements``1(System.Boolean)') as a link.

See `space` after a param ref.

See `T` after a type param ref.

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

<a name='T-Vsxmd-Program-TestGenericType`2'></a>
## TestGenericType&lt;T1, T2&gt; `类型`

##### 命名空间

Vsxmd.Program

##### 概述

Test generic type.

See [TestGenericType`2](#T-Vsxmd-Program-TestGenericType`2 'Vsxmd.Program.TestGenericType`2').

##### 泛型

| 名称 | 描述 |
| ---- | ----------- |
| T1 | Generic type 1. |
| T2 | Generic type 2. |

<a name='M-Vsxmd-Program-TestGenericType`2-TestGenericMethod``2'></a>
### TestGenericMethod&lt;T3, T4&gt;() `方法`

##### 概述

Test generic method.

See [TestGenericMethod``2](#M-Vsxmd-Program-TestGenericType`2-TestGenericMethod``2 'Vsxmd.Program.TestGenericType`2.TestGenericMethod``2').

##### 返回值

Nothing.

##### 参数

此 方法 没有参数.

##### 泛型

| 名称 | 描述 |
| ---- | ----------- |
| T3 | Generic type 3. |
| T4 | Generic type 4. |

<a name='T-Vsxmd-Units-TypeparamUnit'></a>
## TypeparamUnit `类型`

##### 命名空间

Vsxmd.Units

##### 概述

Typeparam unit.

<a name='M-Vsxmd-Units-TypeparamUnit-#ctor-System-Xml-Linq-XElement-'></a>
### #ctor(element) `构造函数`

##### 概述

Initializes a new instance of the [TypeparamUnit](#T-Vsxmd-Units-TypeparamUnit 'Vsxmd.Units.TypeparamUnit') class.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| element | [System.Xml.Linq.XElement](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Xml.Linq.XElement 'System.Xml.Linq.XElement') | The typeparam XML element. |

##### 异常

| 名称 | 描述 |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Throw if XML element name is not `typeparam`. |

<a name='M-Vsxmd-Units-TypeparamUnit-ToMarkdown'></a>
### ToMarkdown() `方法`

##### 概要

*从父继承.*

##### 参数

此 方法 没有参数.

<a name='M-Vsxmd-Units-TypeparamUnit-ToMarkdown-System-Collections-Generic-IEnumerable{System-Xml-Linq-XElement}-'></a>
### ToMarkdown(elements) `方法`

##### 概述

Convert the param XML element to Markdown safely.
If element is `null`, return empty string.

##### 返回值

The generated Markdown.

##### 参数

| 名称 | 类型 | 描述 |
| ---- | ---- | ----------- |
| elements | [System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Xml.Linq.XElement}') | The param XML element list. |
