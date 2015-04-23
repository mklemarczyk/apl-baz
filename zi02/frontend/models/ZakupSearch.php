<?php

namespace frontend\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Zakup;

/**
 * ZakupSearch represents the model behind the search form about `common\models\Zakup`.
 */
class ZakupSearch extends Zakup
{
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'klient_id'], 'integer'],
            [['data_zakupu'], 'safe'],
        ];
    }

    /**
     * @inheritdoc
     */
    public function scenarios()
    {
        // bypass scenarios() implementation in the parent class
        return Model::scenarios();
    }

    /**
     * Creates data provider instance with search query applied
     *
     * @param array $params
     *
     * @return ActiveDataProvider
     */
    public function search($params)
    {
        $query = Zakup::find();

        $dataProvider = new ActiveDataProvider([
            'query' => $query,
        ]);

        $this->load($params);

        if (!$this->validate()) {
            // uncomment the following line if you do not want to any records when validation fails
            // $query->where('0=1');
            return $dataProvider;
        }

        $query->andFilterWhere([
            'id' => $this->id,
            'data_zakupu' => $this->data_zakupu,
            'klient_id' => $this->klient_id,
        ]);

        return $dataProvider;
    }
}
