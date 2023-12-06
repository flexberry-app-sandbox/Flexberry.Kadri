import Mixin from '@ember/object/mixin';
import $ from 'jquery';
import DS from 'ember-data';
import { validator } from 'ember-cp-validations';
import { attr, belongsTo, hasMany } from 'ember-flexberry-data/utils/attributes';

export let Model = Mixin.create({
  iD: DS.attr('number'),
  лК: DS.attr('string'),
  должность: DS.belongsTo('i-i-s-kadri-должности', { inverse: null, async: false })
});

export let ValidationRules = {
  iD: {
    descriptionKey: 'models.i-i-s-kadri-анкеты.validations.iD.__caption__',
    validators: [
      validator('ds-error'),
      validator('number', { allowString: true, integer: true }),
    ],
  },
  лК: {
    descriptionKey: 'models.i-i-s-kadri-анкеты.validations.лК.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
  должность: {
    descriptionKey: 'models.i-i-s-kadri-анкеты.validations.должность.__caption__',
    validators: [
      validator('ds-error'),
      validator('presence', true),
    ],
  },
};

export let defineBaseModel = function (modelClass) {
  modelClass.reopenClass({
    _parentModelName: 'i-i-s-kadri-физ-лица'
  });
};

export let defineProjections = function (modelClass) {
  modelClass.defineProjection('АнкетыE', 'i-i-s-kadri-анкеты', {
    iD: attr('ID', { index: 0 }),
    лК: attr('ЛК', { index: 1 }),
    фИО: attr('ФИО', { index: 2 }),
    контакты: attr('Контакты', { index: 3 }),
    образование: attr('Образование', { index: 4 }),
    опыт_работы: attr('Опыт_работы', { index: 5 }),
    должность: belongsTo('i-i-s-kadri-должности', 'Должность', {
      название: attr('Название', { index: 7, hidden: true })
    }, { index: 6, displayMemberPath: 'название' })
  });

  modelClass.defineProjection('АнкетыL', 'i-i-s-kadri-анкеты', {
    iD: attr('ID', { index: 0 }),
    лК: attr('ЛК', { index: 1 }),
    фИО: attr('ФИО', { index: 2 }),
    контакты: attr('Контакты', { index: 3 }),
    образование: attr('Образование', { index: 4 }),
    опыт_работы: attr('Опыт_работы', { index: 5 }),
    должность: belongsTo('i-i-s-kadri-должности', 'Название', {
      название: attr('Название', { index: 6 })
    }, { index: -1, hidden: true })
  });
};
