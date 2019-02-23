import * as ko from 'knockout';
var img = require("../../images/AspNetCore.png");
class AboutPageViewModel {
    image = img;
}
export default {
    viewModel: AboutPageViewModel,
    template: require('./about.html')
};

