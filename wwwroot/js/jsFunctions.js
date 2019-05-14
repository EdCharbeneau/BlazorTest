window.jsFunctions = {

  showModalDialog: function (dialogId) {
    const dialog = $(`#${dialogId}`);
    console.log('dialog', dialog);
    $(dialog).modal('show');
  }

}