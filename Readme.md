## Blazor Select List Components

### Description
A Blazor select list component styled using Bootstrap 5. This component uses reflection and a generic list of objects to create a `<select>` element and nested `<option>` elements.

### How To Run ###
* Make sure to have .net 7 framework runtime installed on your machine
* Make sure to have dotnet cli installed
* Run `dotnet run` from inside of the BlazorSelectList directory

### Example
```
 <SelectListCustom 
    Data=People
    TextKey="Name"
    ValueKey="Id"
    DefaultText="-- Select a Person --"
    DefaultValue="-1"
    SelectedOptionByValue="2"
    Name="People">
</SelectListCustom>
```

### Attributes


| Attribute | Desc | Required?|
|-----------|------|----------|
| Data      | List of generic objects. Example: `var People = List<Person>`. | Y |
| ValueKey  | Object property key that assigns each option's value attribute. Example: `<option value={ValueKey.Value}>...` | Y
| TextKey | Object property key that assigns each option's text value. Example: `<option ...>{TextKey.Value}>...`. | Y
| DefaultText | Prepends a new option element and assigns the options text value. | N
| DefaultValue | Sets the prepended option element's value. | N
| SelectedOptionByValue | Sets an option element to 'selected' by a matching option value attribute. | N

## Select List JSON Component

### Description
This component works similarly to the select list component but handles a serialized JSON string instead of a list of generic C# objects.Deserialization the JSON string uses C# JSON DOM and `JsonNode`.

### Example
```
<SelectListJson 
    JsonData=@PeopleJson 
    TextKey="Name" 
    ValueKey="Id" 
    DefaultText="-- Select a Person --" 
    DefaultValue="-1"
    SelectedOptionByValue="2">
</SelectListJson>
```

### Attributes


| Attribute | Desc | Required?|
|-----------|------|----------|
| Data      | Serialized JSON array. **Must be a single-dimensional array of objects.** Example: `"[{Id:1, Name: "Bob Smit},...]"` | Y |
| ValueKey  | Object property key that assigns each options value attributes value. Example: `<option value={ValueKey.Value}>...`. The value must not be `undefined` or `null`. | Y
| TextKey | Object property key that assigns each option's text value. Example: `<option ...>{TextKey.Value}>...`. The value must not be `undefined` or `null`. | Y
| DefaultText | Prepends a new option element and assigns the option's text value | N
| DefaultValue | Sets the prepended option element's value. | N
| SelectedOptionByValue | Sets an option element to 'selected' by a matching option value attribute | N