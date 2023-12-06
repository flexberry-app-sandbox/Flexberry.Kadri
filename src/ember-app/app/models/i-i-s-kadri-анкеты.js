import $ from 'jquery';
import { buildValidations } from 'ember-cp-validations';

import {
  defineBaseModel,
  defineProjections,
  ValidationRules,
  Model as АнкетыMixin
} from '../mixins/regenerated/models/i-i-s-kadri-анкеты';

import Физ_лицаModel from './i-i-s-kadri-физ-лица';
import { ValidationRules as ParentValidationRules } from '../mixins/regenerated/models/i-i-s-kadri-физ-лица';

const Validations = buildValidations($.extend({}, ParentValidationRules, ValidationRules), {
  dependentKeys: ['model.i18n.locale'],
});

let Model = Физ_лицаModel.extend(АнкетыMixin, Validations, {
});

defineBaseModel(Model);
defineProjections(Model);

export default Model;
