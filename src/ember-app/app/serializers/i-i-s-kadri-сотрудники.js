import { Serializer as СотрудникиSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kadri-сотрудники';
import Физ_лицаSerializer from './i-i-s-kadri-физ-лица';

export default Физ_лицаSerializer.extend(СотрудникиSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
