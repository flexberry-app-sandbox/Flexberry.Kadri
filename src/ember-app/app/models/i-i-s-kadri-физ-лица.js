import { buildValidations } from 'ember-cp-validations';
import EmberFlexberryDataModel from 'ember-flexberry-data/models/model';

import {
  defineProjections,
  ValidationRules,
  Model as Физ_лицаMixin
} from '../mixins/regenerated/models/i-i-s-kadri-физ-лица';

const Validations = buildValidations(ValidationRules, {
  dependentKeys: ['model.i18n.locale'],
});

let Model = EmberFlexberryDataModel.extend(Физ_лицаMixin, Validations, {
});

defineProjections(Model);

export default Model;
