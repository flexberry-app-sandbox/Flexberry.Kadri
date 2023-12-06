import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.отдел-кадров.caption'),
          title: i18n.t('forms.application.sitemap.отдел-кадров.title'),
          children: [{
            link: 'i-i-s-kadri-контроль-т-з-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-контроль-т-з-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-контроль-т-з-l.title'),
            icon: 'file',
            children: null
          }, {
            link: 'i-i-s-kadri-должности-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-должности-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-должности-l.title'),
            icon: 'archive',
            children: null
          }, {
            link: 'i-i-s-kadri-физ-лица-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-физ-лица-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-физ-лица-l.title'),
            icon: 'edit',
            children: null
          }, {
            link: 'i-i-s-kadri-сотрудники-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-сотрудники-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-сотрудники-l.title'),
            icon: 'book',
            children: null
          }, {
            link: 'i-i-s-kadri-анкеты-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-анкеты-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-анкеты-l.title'),
            icon: 'suitcase',
            children: null
          }, {
            link: 'i-i-s-kadri-отделы-l',
            caption: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-отделы-l.caption'),
            title: i18n.t('forms.application.sitemap.отдел-кадров.i-i-s-kadri-отделы-l.title'),
            icon: 'address card',
            children: null
          }]
        }
      ]
    };
  }),
})