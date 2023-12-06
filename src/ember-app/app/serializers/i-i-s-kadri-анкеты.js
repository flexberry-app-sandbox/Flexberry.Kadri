import { Serializer as АнкетыSerializer } from
  '../mixins/regenerated/serializers/i-i-s-kadri-анкеты';
import Физ_лицаSerializer from './i-i-s-kadri-физ-лица';

export default Физ_лицаSerializer.extend(АнкетыSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
