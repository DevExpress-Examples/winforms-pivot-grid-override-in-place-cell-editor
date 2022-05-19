<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582356/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T515806)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PivotGridControl_CustomCellEdit/Form1.cs) (VB: [Form1.vb](./VB/PivotGridControl_CustomCellEdit/Form1.vb))
<!-- default file list end -->
# How to override the cell editor used for the in-place editing


<p>The following code shows how to handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellEditForEditingtopic">PivotGridControl.CustomCellEditForEditing</a> event to override the cell editor used for the in-place editing.</p>
<p>In the example, the <strong>ProgressBar</strong> in-place editor (repository item) is created to represent values of the "Quantity %" field. In the edit mode, this repository item is changed to <strong>TextEdit</strong>.</p>

<br/>


