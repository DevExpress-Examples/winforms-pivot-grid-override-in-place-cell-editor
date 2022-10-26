<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128582356/21.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T515806)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - Override the In-Place Cell Editor 

This example shows how to change the editor type when the editor is in "edit" mode. 

![Pivot Grid](image/pivotgrid.png)

The `ProgressBar` in-place editor (repository item) displays values of the "Quantity %" field as progress bars. In "edit" mode, the [CustomCellEditForEditing](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomCellEditForEditing) event rises to change this repository item to `TextEdit`.

## Files to Review
* [Form1.cs](./CS/PivotGridControl_CustomCellEdit/Form1.cs) (VB: [Form1.vb](./VB/PivotGridControl_CustomCellEdit/Form1.vb))

## Documentation

[Assigning Editors for In-place Editing](https://docs.devexpress.com/WindowsForms/5896/controls-and-libraries/pivot-grid/data-shaping/editing/assigning-editors-for-in-place-editing)

## More Examples 

- [Pivot Grid for WinForms - Assign In-Place Editors to Different Types of Cells](https://github.com/DevExpress-Examples/winforms-pivotgrid-assign-in-place-editors-to-different-types-of-cells)
