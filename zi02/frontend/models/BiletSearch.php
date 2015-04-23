<?php

namespace frontend\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Bilet;

/**
 * BiletSearch represents the model behind the search form about `common\models\Bilet`.
 */
class BiletSearch extends Bilet
{
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'klasa', 'numer_miejsca', 'lot_id', 'zakup_id'], 'integer'],
            [['cena'], 'number'],
            [['imie', 'nazwisko'], 'safe'],
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
        $query = Bilet::find();

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
            'klasa' => $this->klasa,
            'numer_miejsca' => $this->numer_miejsca,
            'cena' => $this->cena,
            'lot_id' => $this->lot_id,
            'zakup_id' => $this->zakup_id,
        ]);

        $query->andFilterWhere(['like', 'imie', $this->imie])
            ->andFilterWhere(['like', 'nazwisko', $this->nazwisko]);

        return $dataProvider;
    }
}
