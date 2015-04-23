<?php

namespace frontend\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Lot;

/**
 * LotSearch represents the model behind the search form about `common\models\Lot`.
 */
class LotSearch extends Lot
{
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'czas_lotu', 'samolot_id', 'lotnisko_start', 'lotnisko_end'], 'integer'],
            [['numer_lotu', 'data_wylotu'], 'safe'],
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
        $query = Lot::find();

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
            'data_wylotu' => $this->data_wylotu,
            'czas_lotu' => $this->czas_lotu,
            'samolot_id' => $this->samolot_id,
            'lotnisko_start' => $this->lotnisko_start,
            'lotnisko_end' => $this->lotnisko_end,
        ]);

        $query->andFilterWhere(['like', 'numer_lotu', $this->numer_lotu]);

        return $dataProvider;
    }
}
