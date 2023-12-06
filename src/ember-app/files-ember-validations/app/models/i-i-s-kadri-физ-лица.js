import {
  defineNamespace,
  defineProjections,
  Model as Физ_лицаMixin
} from '../mixins/regenerated/models/i-i-s-kadri-физ-лица';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(Физ_лицаMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
