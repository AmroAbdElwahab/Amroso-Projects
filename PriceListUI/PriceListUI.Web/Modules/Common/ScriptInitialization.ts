namespace PriceListUI.ScriptInitialization {
    Q.Config.responsiveDialogs = true;
    Q.Config.rootNamespaces.push('PriceListUI');
    Serenity.EntityDialog.defaultLanguageList = LanguageList.getValue;
}