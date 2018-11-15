<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/PivotGridControl_CustomCellEdit/Form1.cs) (VB: [Form1.vb](./VB/PivotGridControl_CustomCellEdit/Form1.vb))
<!-- default file list end -->
# How to override the cell editor used for the in-place editing


<p>The following code shows how to handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomCellEditForEditingtopic">PivotGridControl.CustomCellEditForEditing</a> event to override the cell editor used for the in-place editing.</p>
<p>In the example, the <strong>ProgressBar</strong> in-place editor (repository item) is created to represent values of the "Quantity %" field. In the edit mode, this repository item is changed to <strong>TextEdit</strong>.</p>

<br/>


