import { Serializer as Физ_лицаSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kadri-физ-лица';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(Физ_лицаSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
