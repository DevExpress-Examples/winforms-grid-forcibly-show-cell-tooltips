<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631935/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E714)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# WinForms Data Grid - How to display tooltips for grid cells if cell content is completely visible

The [ToolTipController](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController) component allows you to manage tooltip behavior for DevExpress Windows Forms UI controls. 

This example handles the [ToolTipController.GetActiveObjectInfo](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController.GetActiveObjectInfo) event to forcibly display tooltips for grid cells with non-trimmed content (value). The event handler creates and initializes a tooltip object if the `e.Info` event parameter is `null` and the mouse pointer is over a grid cell.

![Display Tooltips for WinForms Data Grid Cells](https://raw.githubusercontent.com/DevExpress-Examples/winforms-grid-forcibly-show-cell-tooltips/13.1.4%2B/media/winforms-grid-tooltips.png)

<!-- default file list -->
## Files to Review
* [Form1.cs](./CS/AlwaysShowCellHints/Form1.cs) (VB: [Form1.vb](./VB/AlwaysShowCellHints/Form1.vb))
<!-- default file list end -->

## Documentation
* [ToolTipController](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController)
* [ToolTipController.GetActiveObjectInfo](https://docs.devexpress.com/WindowsForms/DevExpress.Utils.ToolTipController.GetActiveObjectInfo)
* [Data Grid Tooltips](https://docs.devexpress.com/WindowsForms/3512/controls-and-libraries/data-grid/data-grid-tooltips)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-forcibly-show-cell-tooltips&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-grid-forcibly-show-cell-tooltips&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
