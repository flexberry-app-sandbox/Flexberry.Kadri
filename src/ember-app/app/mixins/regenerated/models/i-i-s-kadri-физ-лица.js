import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  контакты: DS.attr('string'),
  образование: DS.attr('string'),
  опыт_работы: DS.attr('string'),
  фИО: DS.attr('string')
});

export let ValidationRules = {
  контакты: {
    descriptionKey: 'models.i-i-s-kadri-физ-лица.validations.контакты.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  образование: {
    descriptionKey: 'models.i-i-s-kadri-физ-лица.validations.образование.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  опыт_работы: {
    descriptionKey: 'models.i-i-s-kadri-физ-лица.validations.опыт_работы.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  фИО: {
    descriptionKey: 'models.i-i-s-kadri-физ-лица.validations.фИО.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('Физ_лицаE', 'i-i-s-kadri-физ-лица', {
    фИО: attr('ФИО', { index: 0 }),
    контакты: attr('Контакты', { index: 1 }),
    образование: attr('Образование', { index: 2 }),
    опыт_работы: attr('Опыт_работы', { index: 3 })
  });

  modelClass.defineProjection('Физ_лицаL', 'i-i-s-kadri-физ-лица', {
    фИО: attr('ФИО', { index: 0 }),
    контакты: attr('Контакты', { index: 1 }),
    образование: attr('Образование', { index: 2 }),
    опыт_работы: attr('Опыт_работы', { index: 3 })
  });
};
