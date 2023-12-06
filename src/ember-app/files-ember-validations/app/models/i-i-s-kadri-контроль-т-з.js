import {
  defineNamespace,
  defineProjections,
  Model as Контроль_ТЗMixin
} from '../mixins/regenerated/models/i-i-s-kadri-контроль-т-з';

import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

let Model = EmberFlexberryDataModel.extend(Контроль_ТЗMixin, {
});

defineNamespace(Model);
defineProjections(Model);

export default Model;
